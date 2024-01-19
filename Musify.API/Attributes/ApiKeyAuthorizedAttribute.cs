using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Musify.API.Data;
using Musify.API.Services;
using Musify.Infra;

namespace Musify.API.Middleware
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class ApiKeyAuthorizedAttribute : Attribute, IAuthorizationFilter
    {
        public ApiKeyPermissions Permission { get; set; } = ApiKeyPermissions.None;

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var apiKey = context.HttpContext.Request.Headers["ApiKey"].ToString();
            var service = context.HttpContext.RequestServices.GetRequiredService<IApiKeyService>();

            // If API key isn't valid.
            if (string.IsNullOrEmpty(apiKey) || !service.IsApiKeyValid(apiKey))
                context.Result = new UnauthorizedResult();

            // If permissions don't check out.
            ApiKeyPermissions apiKeyPermissions = service.GetPermissions(apiKey);
            if ((int)apiKeyPermissions < (int)Permission)
                context.Result = new UnauthorizedResult();
        }
    }
}
