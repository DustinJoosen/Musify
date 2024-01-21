using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Musify.API.Data;
using Musify.API.Middleware;
using Musify.API.Models;
using Musify.API.Services;
using Musify.Infra;
using Musify.Infra.Dtos;

namespace Musify.API.Controllers
{
    [Route("api/[controller]")]
    [ApiKeyAuthorized]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        private IArtistService _service;

        public ArtistsController(IArtistService service)
        {
            this._service = service;
        }

        [HttpGet]
        [ApiKeyAuthorized(Permission = ApiKeyPermissions.Read)]
        public async Task<IActionResult> GetAll()
        {
            var artists = await this._service.GetAll();
            return Ok(artists);
        }

        [HttpGet("{id}")]
        [ApiKeyAuthorized(Permission = ApiKeyPermissions.Read)]
        public async Task<IActionResult> GetById(int id)
        {
            var artist = await this._service.GetById(id);
            if (artist == null)
                return NotFound();

            return Ok(artist);
        }

        [HttpPost("Create")]
        [ApiKeyAuthorized(Permission = ApiKeyPermissions.Write)]
        public async Task<IActionResult> Create(ArtistDto artist)
        {
            if (!ModelState.IsValid)
                return UnprocessableEntity();

            var succeeded = await this._service.Create(artist);
            if (!succeeded)
                return Conflict();

            var created = await this._service.GetById(artist.Id);
            return Ok(created);
        }

        [HttpPut("{id}/Update")]
        [ApiKeyAuthorized(Permission = ApiKeyPermissions.Write)]
        public async Task<IActionResult> Update(int id, ArtistDto artist)
        {
            if (id != artist.Id)
                return UnprocessableEntity();

            var succeeded = await this._service.Update(artist);
            if (!succeeded)
                return Conflict();

            var updated = await this._service.GetById(id);
            return Ok(updated);
        }

        [HttpDelete("{id}/Delete")]
        [ApiKeyAuthorized(Permission = ApiKeyPermissions.Write)]
        public async Task<IActionResult> Delete(int id)
        {
            if (!this._service.Exists(id))
                return NotFound();

            var artist = await this._service.GetById(id);
            
            var succeeded = await this._service.Delete(id);
            if (!succeeded)
                return Conflict();

            return Ok(artist);
        }

        [HttpGet("Count")]
        [ApiKeyAuthorized(Permission = ApiKeyPermissions.Read)]
        public async Task<IActionResult> Count() =>
            Ok(this._service.Count());

        [HttpGet("{id}/Exists")]
        [ApiKeyAuthorized(Permission = ApiKeyPermissions.Read)]
        public async Task<IActionResult> Exists(int id) =>
            this._service.Exists(id) ? Ok(true) : NotFound(false);

    }
}
