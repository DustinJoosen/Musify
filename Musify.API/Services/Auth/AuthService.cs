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

        public bool IsUsernameInUse(string username) =>
            this._context.Users.Any(user => user.Username == username);

        public bool UserExists(int userId) =>
            this._context.Users.Any(user => user.Id == userId);

        public async Task<bool> AreCredentialsValid(CredentialsDto credentials)
        {
            var user = await this._context.Users.FirstOrDefaultAsync(user => user.Username == credentials.Username);
            if (user == null)
                return false;

            return BCrypt.Net.BCrypt.Verify(credentials.Password, user.Password);
        }

        public async Task<UserDto> FindUser(int id) =>
            this._mapper.Map<UserDto>(await this._context.Users.FindAsync(id));

        public async Task<UserDto> FindUser(string apiKey)
        {
            if (!this._apiKeyService.IsApiKeyValid(apiKey) && !this._apiKeyService.IsApiKeyExpired(apiKey))
                return null;

            var key = await this._context.ApiKeys.FindAsync(apiKey);
            if (key.UserId == null)
                return null;

            return await this.FindUser((int)key.UserId);
        }

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
