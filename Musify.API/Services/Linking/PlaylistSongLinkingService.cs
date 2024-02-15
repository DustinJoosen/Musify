﻿using Musify.API.Data;
using Musify.API.Migrations;
using Musify.API.Models;
using Musify.API.Services.Linking;
using Musify.Infra.Dtos;

namespace Musify.API.Services.Link
{
    public class PlaylistSongLinkingService : 
        BaseLinkingService<PlaylistDto, SongDto>,
        ILinkingService<PlaylistDto, SongDto>
    {
        private ApplicationDbContext _context;

        private IPlaylistService _playlistService;
        private ISongService _songService;

        public PlaylistSongLinkingService(ApplicationDbContext context, IPlaylistService playlistService, 
            ISongService songService)
        {
            this._context = context;
            this._playlistService = playlistService;
            this._songService = songService;
        }

        /// <summary>
        /// Links playlist and song
        /// </summary>
        /// <param name="playlistId">ID of playlist to be linked</param>
        /// <param name="songId">ID of song to be linked</param>
        /// <returns>Boolean determining success</returns>
        public override async Task<bool> Link(int playlistId, int songId)
        {
            // Check if the playlist and song actually exist.
            if (!this._playlistService.Exists(playlistId) || !this._songService.Exists(songId))
                return false;

            // Make sure they're not paired.
            if (this._context.PlaylistSongs.Any(playlistsong => playlistsong.PlaylistId == playlistId && playlistsong.SongId == songId))
                return false;

            this._context.PlaylistSongs.Add(new PlaylistSong
            {
                PlaylistId = playlistId,
                SongId = songId
            });

            int changes = await this._context.SaveChangesAsync();
            return changes == 1;
        }

        /// <summary>
        /// Unlinks playlist and song
        /// </summary>
        /// <param name="playlistId">ID of Playlist to be unlinked</param>
        /// <param name="songId">ID of Song to be unlinked</param>
        /// <returns>Boolean determining success</returns>
        public override async Task<bool> Unlink(int playlistId, int songId)
        {
            // Check if the playlist and song actually exist.
            if (!this._playlistService.Exists(playlistId) || !this._songService.Exists(songId))
                return false;

            // Make sure they're paired.
            if (!this._context.PlaylistSongs.Any(playlistsong => playlistsong.PlaylistId == playlistId && playlistsong.SongId == songId))
                return false;

            this._context.PlaylistSongs.Remove(new PlaylistSong
            {
                PlaylistId = playlistId,
                SongId = songId
            });

            int changes = await this._context.SaveChangesAsync();
            return changes == 1;
        }
    }
}