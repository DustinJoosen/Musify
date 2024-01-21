using Microsoft.EntityFrameworkCore;
using Musify.API.Models;

namespace Musify.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<AlbumSong> AlbumSongs { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<PlaylistSong> PlaylistSongs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ApiKey> ApiKeys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AlbumSong>()
                .HasKey(albumsong => new
                {
                    albumsong.AlbumId,
                    albumsong.SongId
                });

            modelBuilder.Entity<PlaylistSong>()
                .HasKey(playlistsong => new
                {
                    playlistsong.PlaylistId,
                    playlistsong.SongId
                });

            modelBuilder.Entity<User>()
                .HasIndex(user => user.Username)
                .IsUnique();

            modelBuilder.Entity<Playlist>()
                .HasIndex(playlist => playlist.Title)
                .IsUnique();

            // Static API Key for the MVVM Gui. 
            modelBuilder.Entity<ApiKey>()
                .HasData(new ApiKey
                {
                    Key = "c9e6b2a15e2d4f8a9b1c76b8a3d5f2e07f1a8d6e9b3c4a2f8e",
                    CreatedAt = DateTime.UtcNow,
                    ExpirationDate = null,
                    Permissions = Infra.ApiKeyPermissions.Write
                });
        }
    }
}
