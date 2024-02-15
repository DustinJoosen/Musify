using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Musify.API.Models;
using Musify.API.Services;
using Musify.Infra;
using Musify.Infra.Dtos;

namespace Musify.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IApiKeyService _keyService;
        private IAuthService _authService;
        public AuthController(IApiKeyService keyService, IAuthService authService)
        {
            this._keyService = keyService;
            this._authService = authService;
        }

        [HttpGet("/test")]
        public async Task<IActionResult> Test()
        {
            var result = this._keyService.ApiKeyExists("5e91c64151fe4b05b94f4d6976199cad9d53c91f57cf4113b3");
            return Ok(result);
        }

        [HttpGet("UsernameUnique")]
        public bool UsernameUnique(string username) =>
            !this._authService.IsUsernameInUse(username);


        [HttpPost("RegisterUser")]
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            if (!ModelState.IsValid)
                return UnprocessableEntity();

            if (this._authService.IsUsernameInUse(registerDto.Username))
                return Conflict("Username is already in use");

            return Ok(await this._authService.RegisterUser(registerDto));
        }

        [HttpPost("CredentialsValid")]
        public async Task<IActionResult> CredentialsValid(CredentialsDto credentials)
        {
            if (!ModelState.IsValid)
                return UnprocessableEntity();

            return Ok(await this._authService.AreCredentialsValid(credentials));
        }

        [HttpGet("GetUser/{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await this._authService.FindUser(id);
            if (user == null)
                return NotFound();

            return Ok(user);

        }

        [HttpPost("GenerateApiKey")]
        public async Task<IActionResult> GenerateApiKey(int? userId, DateTime? expirationDate)
        {
            if (!ModelState.IsValid)
                return UnprocessableEntity();

            var key = await this._keyService.Generate(userId, expirationDate, ApiKeyPermissions.Read);
            return Ok(key);
        }

        [HttpPost("GetApiKeyFromUser")]
        public async Task<IActionResult> GetApiKeyFromUser(CredentialsDto credentials)
        {
            if (!await this._authService.AreCredentialsValid(credentials))
                return Unauthorized();

            var key = await this._keyService.GetApiKeyFromUser(credentials);
            if (key == null)
                return BadRequest();

            return Ok(key);
        }
    }
}
