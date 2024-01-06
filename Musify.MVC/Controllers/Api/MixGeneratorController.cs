using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Musify.MVC.Data;
using Musify.MVC.Models;
using Musify.MVC.Services;
using Musify.MVC.Services.MixGeneration;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Musify.MVC.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MixGeneratorController : ControllerBase
    {
        private IMixGenerationService _mixGenerationService;
        private const string _mixCookieName = "GeneratedMixList";

        public MixGeneratorController(IMixGenerationService mixGenerationService)
        {
            this._mixGenerationService = mixGenerationService;
        }


        // POST api/MixGenerator/Generate
        [HttpPost("Generate")]
        public async Task<StatusCodeResult> Generate()
        {
            int userId = int.Parse(User.Identity.Name);

            // Get list of all songs, and then pick the id's
            var mixedSongs = await this._mixGenerationService.PickLikeBasedSongs(20, userId);
            var mixedSongIds = mixedSongs.Select(song => song.Id).ToList();

            // Save the id's in the cookies.
            Response.Cookies.Delete(_mixCookieName);
            Response.Cookies.Append(_mixCookieName, JsonSerializer.Serialize(mixedSongIds), new()
            {
                Expires = DateTime.Today.AddDays(7)
            });

            // Go back to the mix.
            return Ok();
        }
    }
}
