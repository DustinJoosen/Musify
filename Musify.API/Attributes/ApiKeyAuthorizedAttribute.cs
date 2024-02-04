using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Musify.API.Data;
using Musify.API.Services;
using Musify.API.Services.Logger;
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
            var logger = context.HttpContext.RequestServices.GetRequiredService<ILoggingService>();

            var routeName = string.Join(" - ", context.ActionDescriptor.RouteValues.Select(s => s.Value));

            logger.Log($"Attempting to authorize using ApiKey '{apiKey}' on action {routeName}");

            // If no APIKEY is supplied
            if (string.IsNullOrEmpty(apiKey))
            {
                context.Result = new UnauthorizedObjectResult("No API key is supplied");
                return;
            }

            // If API key isn't valid.
            if (!service.IsApiKeyValid(apiKey))
            {
                context.Result = new UnauthorizedObjectResult("Your API key is invalid");
                return;
            }

            // If API key is expired.
            if (service.IsApiKeyExpired(apiKey))
            {
                context.Result = new UnauthorizedObjectResult("Your API key has expired");
                return;
            }

            // If permissions don't check out.
            ApiKeyPermissions apiKeyPermissions = service.GetPermissions(apiKey);
            if ((int)apiKeyPermissions < (int)Permission)
            {
                context.Result = new UnauthorizedObjectResult("Your API key has insufficient permissions");
                return;
            }

            logger.Log($"Successfully authorized using ApiKey '{apiKey}' on action {routeName}");
        }
    }
}
