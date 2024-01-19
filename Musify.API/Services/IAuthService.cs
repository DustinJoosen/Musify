using Musify.API.Models;
using Musify.Infra.Dtos;

namespace Musify.API.Services
{
    public interface IAuthService
    {
        public Task<UserDto> RegisterUser(RegisterDto registration);
        public Task<bool> AreCredentialsValid(CredentialsDto credentials);
        public Task<UserDto> GetUser(int id);
        public bool IsUsernameInUse(string username);

    }
}