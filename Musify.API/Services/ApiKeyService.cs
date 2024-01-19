using Microsoft.EntityFrameworkCore;
using Musify.API.Data;
using Musify.API.Models;
using Musify.Infra;
using Musify.Infra.Dtos;

namespace Musify.API.Services
{
    public class ApiKeyService : IApiKeyService
    {
        private ApplicationDbContext _context;
        public ApiKeyService(ApplicationDbContext context)
        {
            this._context = context;
        }

        public bool IsApiKeyValid(ApiKey apikey) =>
            this.IsApiKeyValid(apikey.Key);

        public bool IsApiKeyValid(string key) =>
            this._context.ApiKeys.Any(ak => ak.Key == key) && !this.IsApiKeyExpired(key);

        public bool IsApiKeyExpired(string key)
        {
            var apiKey = this._context.ApiKeys.Find(key);
            if (apiKey == null)
                return false;

            if (apiKey.ExpirationDate == null)
                return false;

            return apiKey.ExpirationDate < DateTime.Now;
        }

        public async Task<ApiKeyDto> Generate(int? userId, DateTime? expirationDate, 
            ApiKeyPermissions permissions=ApiKeyPermissions.None)
        {
            string code = (Guid.NewGuid().ToString() + Guid.NewGuid().ToString())
                .Replace("-", string.Empty)
                .Substring(0, 50)
                .ToString() ?? string.Empty;

            var apikey = new ApiKey
            {
                Key = code,
                UserId = userId ?? null,
                Permissions = permissions,
                ExpirationDate = expirationDate,
                CreatedAt = DateTime.Now
            };

            this._context.ApiKeys.Add(apikey);
            await this._context.SaveChangesAsync();

            return new ApiKeyDto(apikey.Key, apikey.UserId, permissions, apikey.ExpirationDate, apikey.CreatedAt);
        }

        public ApiKeyPermissions GetPermissions(string key)
        {
            if (!this.IsApiKeyValid(key))
                return ApiKeyPermissions.None;

            var apikey = this._context.ApiKeys.FirstOrDefault(apikey => apikey.Key == key);
            if (apikey == null)
                return ApiKeyPermissions.None;

            return apikey.Permissions;
        }
    }
}
