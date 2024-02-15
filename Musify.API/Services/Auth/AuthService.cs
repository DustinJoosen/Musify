using AutoMapper;
using BCrypt.Net;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using Musify.API.Data;
using Musify.API.Models;
using Musify.Infra.Dtos;

namespace Musify.API.Services
{
    public class AuthService : IAuthService
    {
        private IApiKeyService _apiKeyService;
        private ApplicationDbContext _context;
        private IMapper _mapper;
        public AuthService(IApiKeyService apiKeyService, ApplicationDbContext context, IMapper mapper)
        {
            this._apiKeyService = apiKeyService;
            this._context = context;
             this._mapper = mapper;
        }

        /// <summary>
        /// Checks wether a username is in use.
        /// </summary>
        /// <param name="username">Username to be checked</param>
        /// <returns>boolean determining if the username is in use</returns>
        public bool IsUsernameInUse(string username) =>
            this._context.Users.Any(user => user.Username == username);

        /// <summary>
        /// Checks wether a user exists
        /// </summary>
        /// <param name="userId">UserId of user to be checked</param>
        /// <returns>A boolean determining wether the user exists</returns>
        public bool UserExists(int userId) =>
            this._context.Users.Any(user => user.Id == userId);


        /// <summary>
        /// Checks wether given credentials are valid.
        /// </summary>
        /// <param name="credentials">Credentials to be checked</param>
        /// <returns>A boolean determining wether the credentials are valid</returns>
        public async Task<bool> AreCredentialsValid(CredentialsDto credentials)
        {
            var user = await this._context.Users.FirstOrDefaultAsync(user => user.Username == credentials.Username);
            if (user == null)
                return false;

            return BCrypt.Net.BCrypt.Verify(credentials.Password, user.Password);
        }

        /// <summary>
        /// Finds user based on userId
        /// </summary>
        /// <param name="id">Id to match user with</param>
        /// <returns>Found <typeparam name="UserDto" /></returns>
        public async Task<UserDto> FindUser(int id) =>
            this._mapper.Map<UserDto>(await this._context.Users.FindAsync(id));

        /// <summary>
        /// Finds user based on ApiKey
        /// </summary>
        /// <param name="apiKey">ApiKey to match user with</param>
        /// <returns>Found <typeparam name="UserDto" /></returns>
        public async Task<UserDto> FindUser(string apiKey)
        {
            if (!this._apiKeyService.ApiKeyExists(apiKey) || this._apiKeyService.IsApiKeyExpired(apiKey))
                return null;

            var key = await this._context.ApiKeys.FindAsync(apiKey);
            if (key?.UserId == null)
                return null;

            return await this.FindUser((int)key.UserId);
        }

        /// <summary>
        /// Registers a user
        /// </summary>
        /// <param name="registration">Registration data</param>
        /// <returns>Created <typeparam name="UserDto" /></returns>
        public async Task<UserDto> RegisterUser(RegisterDto registration)
        {
            if (this.IsUsernameInUse(registration.Username))
                return null;

            var user = new User
            {
                Name = registration.Name,
                Username = registration.Username,
                Password = BCrypt.Net.BCrypt.HashPassword(registration.Password)
            };

            this._context.Users.Add(user);
            await this._context.SaveChangesAsync();

            await this._apiKeyService.Generate(
                userId: user.Id, 
                expirationDate: null,
                permission: Infra.ApiKeyPermissions.Read);

            return this._mapper.Map<UserDto>(user);
        }

    }
}
