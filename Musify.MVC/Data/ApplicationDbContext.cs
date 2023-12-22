using Bogus;
using Microsoft.EntityFrameworkCore;
using Musify.MVC.Models;

namespace Musify.MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Album> Album { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<AlbumSong> AlbumSongs { get; set; }
        public DbSet<PlaylistSong> PlaylistSongs { get; set; }
        public DbSet<UserAlbumLike> UserAlbumLikes { get; set; }
        public DbSet<UserSongLike> UserSongLikes { get; set; }
        public DbSet<UserArtistLike> UserArtistLikes { get; set; }
        public DbSet<UserPlaylistLike> UserPlaylistLikes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            modelBuilder.Entity<AlbumSong>()
                .HasKey(albumsong => new
                {
                    albumsong.AlbumId,
                    albumsong.SongId
                });

            modelBuilder.Entity<PlaylistSong>()
                .HasKey(plso => new
                {
                    plso.PlaylistId,
                    plso.SongId
                });

            modelBuilder.Entity<UserAlbumLike>()
                .HasKey(useralbumlike => new
                {
                    useralbumlike.AlbumId,
                    useralbumlike.UserId
                });

            modelBuilder.Entity<UserSongLike>()
                .HasKey(usersonglike => new
                {
                    usersonglike.SongId,
                    usersonglike.UserId
                });

            modelBuilder.Entity<UserArtistLike>()
                .HasKey(userartistlike => new
                {
                    userartistlike.ArtistId,
                    userartistlike.UserId
                });

            modelBuilder.Entity<UserPlaylistLike>()
                .HasKey(userplaylistlike => new
                {
                    userplaylistlike.PlaylistId,
                    userplaylistlike.UserId
                });

            // Seeding.
            new GeneralDataSeeder(modelBuilder)
                .SeedUsers()
                .SeedArtists()
                .SeedAlbums()
                .SeedSongs()
                .SeedAlbumSongs()
                .SeedPlaylists()
                .SeedPlaylistSongs();

        }
    }
}
