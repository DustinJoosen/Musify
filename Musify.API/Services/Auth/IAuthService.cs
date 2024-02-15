using Musify.API.Models;
using Musify.Infra.Dtos;

namespace Musify.API.Services
{
    public interface IAuthService
    {

        /// <summary>
        /// Registers a user
        /// </summary>
        /// <param name="registration">Registration data</param>
        /// <returns>Created <typeparam name="UserDto" /></returns>
        public Task<UserDto> RegisterUser(RegisterDto registration);

        /// <summary>
        /// Checks wether given credentials are valid.
        /// </summary>
        /// <param name="credentials">Credentials to be checked</param>
        /// <returns>A boolean determining wether the credentials are valid</returns>
        public Task<bool> AreCredentialsValid(CredentialsDto credentials);

        /// <summary>
        /// Finds user based on userId
        /// </summary>
        /// <param name="id">Id to match user with</param>
        /// <returns>Found <typeparam name="UserDto" /></returns>
        public Task<UserDto> FindUser(int id);

        /// <summary>
        /// Finds user based on ApiKey
        /// </summary>
        /// <param name="apiKey">ApiKey to match user with</param>
        /// <returns>Found  <typeparamref name="UserDto" /></returns>
        public Task<UserDto> FindUser(string apiKey);

        /// <summary>
        /// Checks wether a username is in use.
        /// </summary>
        /// <param name="username">Username to be checked</param>
        /// <returns>boolean determining if the username is in use</returns>
        public bool IsUsernameInUse(string username);

        /// <summary>
        /// Checks wether a user exists
        /// </summary>
        /// <param name="userId">UserId of user to be checked</param>
        /// <returns>A boolean determining wether the user exists</returns>
        public bool UserExists(int userId);
    }
}