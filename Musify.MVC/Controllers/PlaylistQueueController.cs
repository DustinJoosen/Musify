using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Musify.MVC.Data;
using Musify.MVC.Models.ViewModels;
using Musify.MVC.Models;

namespace Musify.MVC.Controllers
{
    public class PlaylistQueueController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlaylistQueueController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> FormatQueue(int id)
        {
            using var transaction = _context.Database.BeginTransaction();

            try
            {
                await _context.Database.ExecuteSqlRawAsync("DELETE FROM PlaylistQueue;");
                transaction.Commit();

                return Json(new { Message = "OK" });
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return Json(new { Message = $"Error: {ex.Message}" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddQueue(PlaylistQueue model)
        {
            var existingsong = await _context.PlaylistQueue
             .FirstOrDefaultAsync(q => q.SongId == model.SongId && q.AlbumId == null && q.PlaylistId == null);
            var existingalbum = await _context.PlaylistQueue
             .FirstOrDefaultAsync(q => q.SongId == null && q.AlbumId == model.AlbumId && q.PlaylistId == null);
            var existingplaylist = await _context.PlaylistQueue
             .FirstOrDefaultAsync(q => q.SongId == null && q.AlbumId == null && q.PlaylistId == model.PlaylistId);

            if (existingsong != null || existingalbum != null || existingplaylist != null)
            {
                return Json(new { Message = "Item Already Available in queue" });
            }
            else if (ModelState.IsValid)
            {
                _context.Add(model);
                await _context.SaveChangesAsync();
                return Json(new { QueueId = model.QueueId });
            }
            return Json(new { Message = "Something went wrong" });
        }

        [HttpGet]
        public async Task<IActionResult> GetQueueItems()
        {
            try
            {
                var queueItems = await _context.PlaylistQueue.ToListAsync();

                var semaphore = new SemaphoreSlim(1, 1); // 1 Maximum 

                var result = await Task.WhenAll(queueItems.Select(async queue =>
                {
                    await semaphore.WaitAsync();
                    try
                    {
                        if (queue.PlaylistId != null)
                        {
                            // Adding the playlist to the queue
                            var playlist = await _context.Playlists
                                .Where(p => p.Id == queue.PlaylistId)
                                .Select(p => new PlayListSongViewModel
                                {
                                    PlaylistId = p.Id,
                                    songs = p.PlaylistSongs!.Select(ps => new SongViewModel
                                    {
                                        SongId = ps.Song!.Id,
                                        Title = ps.Song.Title,
                                    }).ToList()
                                })
                                .FirstOrDefaultAsync();

                            return playlist;
                        }
                        else if (queue.AlbumId != null)
                        {
                            // Handle album case
                            var album = await _context.Album
                                .Where(a => a.Id == queue.AlbumId)
                                .Select(a => new PlayListSongViewModel
                                {
                                    PlaylistId = 0,
                                    PlaylistName = a.Title,
                                    songs = a.AlbumSongs!.Select(song => new SongViewModel
                                    {
                                        SongId = song.SongId,
                                        Title = song.Song.Title,
                                    }).ToList()
                                })
                                .FirstOrDefaultAsync();

                            return album;
                        }
                        else if (queue.SongId != null)
                        {
                            // Handle standalone song case
                            var song = await _context.Songs
                                .FirstOrDefaultAsync(s => s.Id == queue.SongId);

                            return new PlayListSongViewModel
                            {
                                songs = new List<SongViewModel>
                        {
                            new SongViewModel
                            {
                                SongId = song!.Id,
                                Title = song.Title,
                            }
                        }
                            };
                        }
                        else
                        {
                            return null;
                        }
                    }
                    finally
                    {
                        semaphore.Release();
                    }
                }));

                // Return the valid results
                var validQueueItems = result.Where(item => item != null).ToList();
                return Json(new { queue = validQueueItems });
            }
            catch (Exception ex)
            {
                return Json(new { Message = $"Error: {ex.Message}" });
            }
        }




        [HttpGet]
        public async Task<IActionResult> GetLastQueueItem(int queueId)
        {
            int? id = 0; int? PLId = 0; int? AlbumId = 0;

            if (queueId != 0)
            {
                var queue = await _context.PlaylistQueue
                .FirstOrDefaultAsync(m => m.QueueId == queueId);

                if (queue != null && queue.PlaylistId != null)
                {
                    PLId = queue.PlaylistId;
                }
                else if (queue != null && queue.AlbumId != null)
                {
                    AlbumId = queue.AlbumId;
                }
                else if (queue != null && queue.SongId != null)
                {
                    id = queue.SongId;
                }
                else
                {
                    return Json(new { Message = "Something went wrong" });
                }
            }
            if (PLId != 0)
            {
                // Retrieve playlist information
                var viewModel = await _context.Playlists
           .Where(p => p.Id == PLId)
           .Select(p => new PlayListSongViewModel
           {
               PlaylistId = p.Id,
               songs = p.PlaylistSongs!.Select(ps => new SongViewModel
               {
                   SongId = ps.Song!.Id,
                   Title = ps.Song.Title,
               }).ToList()
           })
           .FirstOrDefaultAsync();

                if (viewModel == null)
                {
                    return NotFound();
                }
                return Json(new { queue = viewModel });
            }
            else if (AlbumId != 0)
            {
                var viewModel = await _context.Album
           .Where(p => p.Id == AlbumId)
           .Select(p => new PlayListSongViewModel
           {
               PlaylistId = 0,
               PlaylistName = p.Title,
               songs = p.AlbumSongs!.Select(ps => new SongViewModel
               {
                   SongId = ps.SongId,
                   Title = ps.Song.Title,
               }).ToList()
           })
           .FirstOrDefaultAsync();
                return Json(new { queue = viewModel });

            }
            else if (id != 0)
            {
                PlayListSongViewModel playlistSong = new PlayListSongViewModel();
                var song = await _context.Songs
                                .FirstOrDefaultAsync(m => m.Id == id);
                if (song != null)
                {
                    playlistSong = new PlayListSongViewModel
                    {
                        songs = new List<SongViewModel>
                    {
                        new SongViewModel
                        {
                            SongId = song!.Id,
                            Title = song.Title,
                        }
                    }
                    };
                }
                return Json(new { queue = playlistSong });
            }
            else
            {
                return Json(new { Message = "Something went wrong" });

            }
        }
    }
}
