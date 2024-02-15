using BCrypt.Net;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

        /// <summary>
        /// Checks wether an ApiKey exists. 
        /// Note that this does not check wether the key is expired.
        /// </summary>
        /// <param name="key">ApiKey object to be checked</param>
        /// <returns>boolean determing if the apikey exists</returns>
        public bool ApiKeyExists(string key) =>
            this._context.ApiKeys.Any(ak => ak.Key == key);
            

        /// <summary>
        /// Check wether the given ApiKey is expired or not.
        /// </summary>
        /// <param name="key">ApiKey to be checked</param>
        /// <returns>If the key is expired, it returns true. </returns>
        public bool IsApiKeyExpired(string key)
        {
            var apiKey = this._context.ApiKeys.Find(key);
            if (apiKey == null)
                return false;

            if (apiKey.ExpirationDate == null)
                return false;

            return apiKey.ExpirationDate < DateTime.Now;
        }


        /// <summary>
        /// Generates an ApiKey.
        /// </summary>
        /// <param name="userId">UserId to match with the apiKey</param>
        /// <param name="expirationDate">Expiration date for the apiKey</param>
        /// <param name="permissions">Permissions granted with the key</param>
        /// <returns>The created  <typeparamref name="ApiKeyDto"/></returns>
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


        /// <summary>
        /// Returns the permissions granted with the specified apiKey
        /// </summary>
        /// <param name="key">ApiKey to be checked</param>
        /// <returns>The permissions granted with the  <typeparamref name="ApiKeyPermissions"/></returns>
        public ApiKeyPermissions GetPermissions(string key)
        {
            if (!this.ApiKeyExists(key) && !this.IsApiKeyExpired(key))
                return ApiKeyPermissions.None;

            var apikey = this._context.ApiKeys.FirstOrDefault(apikey => apikey.Key == key);
            if (apikey == null)
                return ApiKeyPermissions.None;

            return apikey.Permissions;
        }

        /// <summary>
        /// Gives an ApiKey that belongs to a specified user.
        /// </summary>
        /// <param name="credentials">Login credentials for the specified user</param>
        /// <returns>The first apiKey found matching the user</returns>
        public async Task<string?> GetApiKeyFromUser(CredentialsDto credentials)
        {
            var user = await this._context.Users.SingleOrDefaultAsync(user => user.Username == credentials.Username);
            if (user == null)
                return null;

            if (!BCrypt.Net.BCrypt.Verify(credentials.Password, user.Password))
                return null;

            var apikey = await this._context.ApiKeys.FirstOrDefaultAsync(key => key.UserId == user.Id);
            if (apikey == null)
                return null;

            return apikey.Key;
        }
    }
}
