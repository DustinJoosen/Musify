using AutoMapper;
using Microsoft.AspNetCore.Authorization;
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
    [ApiController]
    public class AlbumsController : ControllerBase
    {
        private IAlbumService _service;
        private IArtistService _artistService;

        public AlbumsController(IAlbumService service, IArtistService artistService)
        {
            this._service = service;
            this._artistService = artistService;
        }

        [ApiKeyAuthorized(Permission = ApiKeyPermissions.Read)]
        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var album = await this._service.GetById(id);
            if (album == null)
                return NotFound();

            return Ok(album);
        }

        [HttpGet("GetAll")]
        [ApiKeyAuthorized(Permission = ApiKeyPermissions.Read)]
        public async Task<IActionResult> GetAll()
        {
            var albums = await this._service.GetAll();
            return Ok(albums);
        }

        [HttpPost("Create")]
        [ApiKeyAuthorized(Permission = ApiKeyPermissions.Write)]
        public async Task<IActionResult> Create([Bind("Id", "ArtistId", "Title", "CoverImage", "Genre")]AlbumDto album)
        {
            if (!ModelState.IsValid)
                return UnprocessableEntity();

            // Ensure ArtistId remains valid
            if (!this._artistService.Exists(album.ArtistId))
                return UnprocessableEntity();

            var succeeded = await this._service.Create(album);
            if (!succeeded)
                return Conflict();

            var created = await this._service.GetById(album.Id);
            return Ok(created);
        }

        [HttpPut("Update")]
        [ApiKeyAuthorized(Permission = ApiKeyPermissions.Write)]
        public async Task<IActionResult> Update(int id, AlbumDto album)
        {
            if (id != album.Id)
                return UnprocessableEntity();

            var succeeded = await this._service.Update(album);
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

            var album = await this._service.GetById(id);
            
            var succeeded = await this._service.Delete(id);
            if (!succeeded)
                return Conflict();

            return Ok(album);
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
