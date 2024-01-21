using Musify.API.Models;
using Musify.Infra.Dtos;

namespace Musify.API.Services
{
    public interface IAuthService
    {
        public Task<UserDto> RegisterUser(RegisterDto registration);
        public Task<bool> AreCredentialsValid(CredentialsDto credentials);
        public Task<UserDto> FindUser(int id);
        public Task<UserDto> FindUser(string apiKey);
        public bool IsUsernameInUse(string username);
        public bool UserExists(int userId);
    }
}