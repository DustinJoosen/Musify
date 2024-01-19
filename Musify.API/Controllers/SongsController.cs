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
    public class SongsController : ControllerBase
    {
        private ISongService _service;

        public SongsController(ISongService service)
        {
            this._service = service;
        }


        [HttpGet("GetById")]
        [ApiKeyAuthorized(Permission = ApiKeyPermissions.Read)]
        public async Task<IActionResult> GetById(int id)
        {
            var song = await this._service.GetById(id);
            if (song == null)
                return NotFound();

            return Ok(song);
        }

        [HttpGet("GetAll")]
        [ApiKeyAuthorized(Permission = ApiKeyPermissions.Read)]
        public async Task<IActionResult> GetAll()
        {
            var songs = await this._service.GetAll();
            return Ok(songs);
        }

        [HttpPost("Create")]
        [ApiKeyAuthorized(Permission = ApiKeyPermissions.Write)]
        public async Task<IActionResult> Create(SongDto song)
        {
            if (!ModelState.IsValid)
                return UnprocessableEntity();

            var succeeded = await this._service.Create(song);
            if (!succeeded)
                return Conflict();

            var created = await this._service.GetById(song.Id);
            return Ok(created);
        }

        [HttpPut("Update")]
        [ApiKeyAuthorized(Permission = ApiKeyPermissions.Write)]
        public async Task<IActionResult> Update(int id, SongDto song)
        {
            if (id != song.Id)
                return UnprocessableEntity();

            var succeeded = await this._service.Update(song);
            if (!succeeded)
                return Conflict();

            var updated = await this._service.GetById(id);
            return Ok(updated);
        }

        [HttpDelete("Delete")]
        [ApiKeyAuthorized(Permission = ApiKeyPermissions.Write)]
        public async Task<IActionResult> Delete(int id)
        {
            if (!this._service.Exists(id))
                return NotFound();

            var song = await this._service.GetById(id);
            
            var succeeded = await this._service.Delete(id);
            if (!succeeded)
                return Conflict();

            return Ok(song);
        }

        [HttpGet("Count")]
        [ApiKeyAuthorized(Permission = ApiKeyPermissions.Read)]
        public async Task<IActionResult> Count() =>
            Ok(this._service.Count());

        [HttpGet("Exists")]
        [ApiKeyAuthorized(Permission = ApiKeyPermissions.Read)]
        public async Task<IActionResult> Exists(int id) =>
            this._service.Exists(id) ? Ok(true) : NotFound(false);

    }
}
