using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Musify.API.Data;
using Musify.API.Middleware;
using Musify.API.Models;
using Musify.API.Services;
using Musify.API.Services.Link;
using Musify.Infra;
using Musify.Infra.Dtos;

namespace Musify.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumsController : ControllerBase
    {
        private IAlbumService _albumService;
        private IArtistService _artistService;
        private ILinkingService<AlbumDto, SongDto> _linkingService;

        public AlbumsController(IAlbumService albumService, IArtistService artistService, 
            ILinkingService<AlbumDto, SongDto> linkingService)
        {
            this._albumService = albumService;
            this._artistService = artistService;
            this._linkingService = linkingService;
        }

        [HttpGet]
        [ApiKeyAuthorized(Permission = ApiKeyPermissions.Read)]
        public async Task<IActionResult> GetAll()
        {
            var albums = await this._albumService.GetAll();
            return Ok(albums);
        }

        [ApiKeyAuthorized(Permission = ApiKeyPermissions.Read)]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var album = await this._albumService.GetById(id);
            if (album == null)
                return NotFound();

            return Ok(album);
        }

        [HttpPost("Create")]
        [ApiKeyAuthorized(Permission = ApiKeyPermissions.Write)]
        public async Task<IActionResult> Create([Bind("Id", "ArtistId", "Title", "CoverImage", "Genre")]AlbumDto album)
        {
            if (!ModelState.IsValid)
                return UnprocessableEntity();

            // Ensure ArtistId remains valid
            if (!this._artistService.Exists(album.ArtistId) && album.ArtistId != 0)
                return UnprocessableEntity();

            var succeeded = await this._albumService.Create(album);
            if (!succeeded)
                return Conflict();

            var created = await this._albumService.GetById(album.Id);
            return Ok(created);
        }

        [HttpPut("{id}/Update")]
        [ApiKeyAuthorized(Permission = ApiKeyPermissions.Write)]
        public async Task<IActionResult> Update(int id, AlbumDto album)
        {
            if (id != album.Id)
                return UnprocessableEntity();

            // Ensure ArtistId remains valid
            if (!this._artistService.Exists(album.ArtistId) && album.ArtistId != 0)
                return UnprocessableEntity();

            var succeeded = await this._albumService.Update(album);
            if (!succeeded)
                return Conflict();

            var updated = await this._albumService.GetById(id);
            return Ok(updated);
        }

        [HttpDelete("{id}/Delete")]
        [ApiKeyAuthorized(Permission = ApiKeyPermissions.Write)]
        public async Task<IActionResult> Delete(int id)
        {
            if (!this._albumService.Exists(id))
                return NotFound();

            var album = await this._albumService.GetById(id);
            
            var succeeded = await this._albumService.Delete(id);
            if (!succeeded)
                return Conflict();

            return Ok(album);
        }

        [HttpPost("{albumId}/LinkSong/{songId}")]
        [ApiKeyAuthorized(Permission = ApiKeyPermissions.Write)]
        public async Task<IActionResult> LinkSong(int albumId, int songId)
        {
            if (songId == 0 || albumId == 0)
                return NotFound();

            bool succeeded = await this._linkingService.Link(albumId, songId);
            if (!succeeded)
                return Conflict("Could not link album and song");

            return Ok(new AlbumSong
            {
                AlbumId = albumId,
                SongId = songId,
            });
        }

        [HttpDelete("{albumId}/UnlinkSong/{songId}")]
        [ApiKeyAuthorized(Permission = ApiKeyPermissions.Write)]
        public async Task<IActionResult> UnlinkSong(int albumId, int songId)
        {
            if (songId == 0 || albumId == 0)
                return NotFound();

            bool succeeded = await this._linkingService.Unlink(albumId, songId);
            if (!succeeded)
                return Conflict("Could not unlink album and song");

            return Ok(new AlbumSong
            {
                AlbumId = albumId,
                SongId = songId
            });
        }

        [HttpGet("Count")]
        [ApiKeyAuthorized(Permission = ApiKeyPermissions.Read)]
        public async Task<IActionResult> Count() =>
            Ok(this._albumService.Count());

        [HttpGet("{id}/Exists")]
        [ApiKeyAuthorized(Permission = ApiKeyPermissions.Read)]
        public async Task<IActionResult> Exists(int id) =>
            this._albumService.Exists(id) ? Ok(true) : NotFound(false);
    }
}
