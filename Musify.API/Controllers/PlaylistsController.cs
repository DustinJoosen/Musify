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
    public class PlaylistsController : ControllerBase
    {
        private IPlaylistService _service;

        public PlaylistsController(IPlaylistService service)
        {
            this._service = service;
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var playlist = await this._service.GetById(id);
            if (playlist == null)
                return NotFound();

            return Ok(playlist);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var playlists = await this._service.GetAll();
            return Ok(playlists);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(PlaylistDto playlist)
        {
            if (!ModelState.IsValid)
                return UnprocessableEntity();

            var succeeded = await this._service.Create(playlist);
            if (!succeeded)
                return Conflict();

            var created = await this._service.GetById(playlist.Id);
            return Ok(created);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(int id, PlaylistDto playlist)
        {
            if (id != playlist.Id)
                return UnprocessableEntity();

            var succeeded = await this._service.Update(playlist);
            if (!succeeded)
                return Conflict();

            var updated = await this._service.GetById(id);
            return Ok(updated);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!this._service.Exists(id))
                return NotFound();

            var playlist = await this._service.GetById(id);
            
            var succeeded = await this._service.Delete(id);
            if (!succeeded)
                return Conflict();

            return Ok(playlist);
        }

        [HttpGet("TitleUnique")]
        public bool TitleUnique(string title) =>
            !this._service.IsTitleAlreadyUsed(title);

        [HttpGet("Count")]
        public async Task<IActionResult> Count() =>
            Ok(this._service.Count());

        [HttpGet("Exists")]
        public async Task<IActionResult> Exists(int id) =>
            this._service.Exists(id) ? Ok(true) : NotFound(false);

    }
}
