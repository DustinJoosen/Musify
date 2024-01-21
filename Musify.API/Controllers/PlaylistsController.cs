using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
    [ApiKeyAuthorized]
    [ApiController]
    public class PlaylistsController : ControllerBase
    {
        private IPlaylistService _playlistService;
        private IAuthService _authService;
        private ILinkingService<PlaylistDto, SongDto> _linkingService;

        public PlaylistsController(IPlaylistService service, IAuthService authService,
            ILinkingService<PlaylistDto, SongDto> linkingService)
        {
            this._playlistService = service;
            this._authService = authService;
            this._linkingService = linkingService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var playlists = await this._playlistService.GetAll();
            return Ok(playlists);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var playlist = await this._playlistService.GetById(id);
            if (playlist == null)
                return NotFound();

            return Ok(playlist);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(PlaylistDto playlist)
        {
            if (!ModelState.IsValid)
                return UnprocessableEntity("Playlist is not in valid format");

            var succeeded = await this._playlistService.Create(playlist);
            if (!succeeded)
                return Conflict("Could not create playlist");

            var created = await this._playlistService.GetById(playlist.Id);
            return Ok(created);
        }

        [HttpPut("{id}/Update")]
        public async Task<IActionResult> Update(int id, PlaylistDto playlist)
        {
            // Ensure only the owner of the playlist can update it.
            if (!await this._playlistService.IsOwnerOfPlaylist(id, Request.Headers["ApiKey"]))
                return Unauthorized("Playlist owner doesn't match owner of api key");

            // Check if the identifiers match.
            if (id != playlist.Id)
                return UnprocessableEntity("Given Id doesn't match Id of playlist");
            
            // Attempt to update the playlist.
            var succeeded = await this._playlistService.Update(playlist);
            if (!succeeded)
                return Conflict("Could not update playlist");

            var updated = await this._playlistService.GetById(id);
            return Ok(updated);
        }

        [HttpDelete("{id}/Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            // Ensure only the owner of the playlist can delete it.
            if (!await this._playlistService.IsOwnerOfPlaylist(id, Request.Headers["ApiKey"]))
                return Unauthorized("Playlist owner doesn't match owner of api key");

            if (!this._playlistService.Exists(id))
                return NotFound();

            var playlist = await this._playlistService.GetById(id);
            
            var succeeded = await this._playlistService.Delete(id);
            if (!succeeded)
                return Conflict("Could not delete playlist");

            return Ok(playlist);
        }

        [HttpPost("{playlistId}/LinkSong/{songId}")]
        public async Task<IActionResult> LinkSong(int playlistId, int songId)
        {
            if (songId == 0 || playlistId == 0)
                return NotFound();

            // Ensure only the owner of the playlist can manage it.
            if (!await this._playlistService.IsOwnerOfPlaylist(playlistId, Request.Headers["ApiKey"]))
                return Unauthorized("Playlist owner doesn't match owner of api key");

            bool succeeded = await this._linkingService.Link(playlistId, songId);
            if (!succeeded)
                return Conflict("Could not link playlist and song");

            return Ok(new PlaylistSong
            {
                PlaylistId = playlistId,
                SongId = songId,
            });
        }

        [HttpDelete("{playlistId}/UnlinkSong/{songId}")]
        public async Task<IActionResult> UnlinkSong(int playlistId, int songId)
        {
            if (songId == 0 || playlistId == 0)
                return NotFound();

            // Ensure only the owner of the playlist can manage it.
            if (!await this._playlistService.IsOwnerOfPlaylist(playlistId, Request.Headers["ApiKey"]))
                return Unauthorized("Playlist owner doesn't match owner of api key");

            bool succeeded = await this._linkingService.Unlink(playlistId, songId);
            if (!succeeded)
                return Conflict("Could not unlink playlist and song");

            return Ok(new PlaylistSong
            {
                PlaylistId = playlistId,
                SongId = songId
            });
        }

        [HttpGet("TitleUnique")]
        public bool TitleUnique(string title) =>
            !this._playlistService.IsTitleAlreadyUsed(title);

        [HttpGet("Count")]
        public async Task<IActionResult> Count() =>
            Ok(this._playlistService.Count());

        [HttpGet("{id}/Exists")]
        public async Task<IActionResult> Exists(int id) =>
            this._playlistService.Exists(id) ? Ok(true) : NotFound(false);

    }
}
