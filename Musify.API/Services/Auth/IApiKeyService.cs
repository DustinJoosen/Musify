using Musify.API.Models;
using Musify.Infra;
using Musify.Infra.Dtos;

namespace Musify.API.Services
{
    public interface IApiKeyService
    {
        public bool IsApiKeyValid(ApiKey apikey);
        public bool IsApiKeyValid(string key);
        public bool IsApiKeyExpired(string key);
        public Task<ApiKeyDto> Generate(int? userId, DateTime? expirationDate, ApiKeyPermissions permission=ApiKeyPermissions.None);
        public ApiKeyPermissions GetPermissions(string apiKey);
    }
}