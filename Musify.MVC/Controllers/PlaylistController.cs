﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using Musify.MVC.Data;
using Musify.MVC.Dtos;
using Musify.MVC.Models;
using Musify.MVC.Services;
using Musify.MVC.ViewModels;

namespace Musify.MVC.Controllers
{
    public class PlaylistController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILikeService<Playlist> _playlistLikeService;
        private readonly INotyfService _notyf;
        private User _user;
        
        public PlaylistController(ApplicationDbContext context, 
            ILikeService<Playlist> playlistLikeService, INotyfService notyf)
        {
            _context = context;
            _playlistLikeService = playlistLikeService;

            this._notyf = notyf;
        }

        // GET: Playlist
        public async Task<IActionResult> Index()
        {
            var _userId = int.Parse(User.Identity.Name);
            var user = await _context.Users.FindAsync(_userId);

            if (user == null)
                return NotFound();

            var playlists = (await _context.Playlists.Include(p => p.User)
                .Include(p => p.PlaylistSongs)
                .ThenInclude(songs => songs.Song)
                .ToListAsync()).Select(p => (new PlaylistViewModel()
                {
                    Id = p.Id,
                    Songs = p.PlaylistSongs.Select(p => p.Song),
                    Title = p.Title,
                    Username = p.User.Name,
                    Liked = _playlistLikeService.IsLiked(_userId, p.Id),
                }, p.PlaylistSongs.Sum(songs => songs.Song.Duration)))
                .ToList();

            return View(playlists);
        }

        // GET: Playlist/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Playlists == null)
            {
                return NotFound();
            }

            var playlist = await _context.Playlists
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (playlist == null)
            {
                return NotFound();
            }

            return View(playlist);
        }

        [HttpPost]
        public IActionResult UserID()
        {
            return Ok(User.Identity.Name);
        }

        // GET: Playlist/Create
        public async Task<IActionResult> Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name");
            ViewData["UserName"] = (await _context.Users.FindAsync(int.Parse(User.Identity.Name))).Username;
            return View();
        }

        // POST: Playlist/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,UserId,Timestamp,IsPublic")] Playlist playlist)
        {
            playlist.UserId = int.Parse(User.Identity.Name);

            _context.Add(playlist);
            await _context.SaveChangesAsync();

            _notyf.Success("Successfuly created playlist");
            return RedirectToAction(nameof(Index));
        }

        // GET: Playlist/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Playlists == null)
            {
                return NotFound();
            }

            var playlist = await _context.Playlists.FindAsync(id);
            if (playlist == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name", playlist.UserId);
            ViewData["UserName"] = (await _context.Users.FindAsync(int.Parse(User.Identity.Name))).Username;

            return View(playlist);
        }

        // POST: Playlist/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,UserId,Timestamp,IsPublic")] Playlist playlist)
        {
            playlist.UserId = int.Parse(User.Identity.Name);

            if (id != playlist.Id)
            {
                return NotFound();
            }

                try
                {
                    _context.Update(playlist);

                    _notyf.Success("Successfuly updated playlist");
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlaylistExists(playlist.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            
                ViewData["UserName"] = (await _context.Users.FindAsync(int.Parse(User.Identity.Name))).Username;
                return RedirectToAction(nameof(Index));
        }

        // GET: Playlist/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Playlists == null)
            {
                return NotFound();
            }

            var playlist = await _context.Playlists
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (playlist == null)
            {
                return NotFound();
            }

            return View(playlist);
        }

        // POST: Playlist/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Playlists == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Playlists'  is null.");
            }
            var playlist = await _context.Playlists.FindAsync(id);
            if (playlist != null)
            {
                _context.Playlists.Remove(playlist);
            }
            
            await _context.SaveChangesAsync();
            
            _notyf.Success("Successfuly deleted playlist");
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Songs(int? id)
        {
			if (id == null || _context.Playlists == null)
            {
                return NotFound();
            }

            var playlist = await _context.Playlists
                .Include(p => p.User)
                .Include(p => p.PlaylistSongs)
                .ThenInclude(s => s.Song)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (playlist == null)
            {
                return NotFound();
            }
            return View((playlist, (await _context.Songs.ToListAsync())));
        }

        [HttpPost, ActionName("Songs"), ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveSong(int id)
        {
            var song = await _context.PlaylistSongs.FirstOrDefaultAsync(p => p.SongId == id);
            if (song == null)
            {
                return NotFound();
            }
            _context.PlaylistSongs.Remove(song);
            await _context.SaveChangesAsync();

            _notyf.Success("Successfuly removed song from playlist");
            return RedirectToAction(nameof(Songs));
        }

        [HttpPost, ActionName("AddSongs"), ValidateAntiForgeryToken]
        public async Task<IActionResult> AddSong(int playlistId, int id)
        {
            var playlist = await _context.Playlists
            .Include(p => p.User)
            .Include(p => p.PlaylistSongs)
            .ThenInclude(s => s.Song)
            .FirstOrDefaultAsync(m => m.Id == playlistId);

            if(!playlist.PlaylistSongs.Any(p => p.SongId == id))
            {
                var playListSong = new PlaylistSong()
                {
                    PlaylistId = playlistId,
                    SongId = id,
                };
                _context.PlaylistSongs.Add(playListSong);
                await _context.SaveChangesAsync();
            }

            _notyf.Success("Successfuly added song to playlist");
            return RedirectToAction(nameof(Songs), new {id = playlistId});
        }
        private bool PlaylistExists(int id)
        {
          return (_context.Playlists?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
