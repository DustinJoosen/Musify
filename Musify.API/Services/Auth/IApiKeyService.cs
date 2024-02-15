using Musify.API.Models;
using Musify.Infra;
using Musify.Infra.Dtos;

namespace Musify.API.Services
{
    public interface IApiKeyService
    {
        /// <summary>
        /// Checks wether an ApiKey exists. 
        /// Note that this does not check wether the key is expired.
        /// </summary>
        /// <param name="key">ApiKey object to be checked</param>
        /// <returns>boolean determing if the apikey exists</returns>
        public bool ApiKeyExists(string key);

        /// <summary>
        /// Check wether the given ApiKey is expired or not.
        /// </summary>
        /// <param name="key">ApiKey to be checked</param>
        /// <returns>If the key is expired, it returns true. </returns>
        public bool IsApiKeyExpired(string key);

        /// <summary>
        /// Generates an ApiKey.
        /// </summary>
        /// <param name="userId">UserId to match with the apiKey</param>
        /// <param name="expirationDate">Expiration date for the apiKey</param>
        /// <param name="permissions">Permissions granted with the key</param>
        /// <returns>The created <typeparamref name="ApiKeyDto"/></returns>
        public Task<ApiKeyDto> Generate(int? userId, DateTime? expirationDate, ApiKeyPermissions permission=ApiKeyPermissions.None);

        /// <summary>
        /// Returns the permissions granted with the specified apiKey
        /// </summary>
        /// <param name="key">ApiKey to be checked</param>
        /// <returns>The permissions granted with the  <typeparamref name="ApiKeyPermissions"/></returns>
        public ApiKeyPermissions GetPermissions(string apiKey);


        /// <summary>
        /// Gives an ApiKey that belongs to a specified user.
        /// </summary>
        /// <param name="credentials">Login credentials for the specified user</param>
        /// <returns>The first apiKey found matching the user</returns>
        public Task<string?> GetApiKeyFromUser(CredentialsDto credentials);
    }
}