using AutoMapper;
using Musify.API.Models;
using Musify.Infra.Dtos;

namespace Musify.API
{
    public class MappingProfile : Profile
    {
        private static Artist DeletedArtist = new Artist
        {
            Id = 0,
            Name = "Deleted artist",
            Genre = "-",
            ArtistImage = "deleted.png"
        };


        public MappingProfile()
        {
            CreateMap<Artist, ArtistDto>();
            CreateMap<ArtistDto, Artist>();

            CreateMap<Album, AlbumDto>()
                .ForMember(dest => dest.Artist, opt =>
                    opt.MapFrom(src => src.Artist ?? DeletedArtist))
                .ForMember(dest => dest.Songs, opt => opt.MapFrom(src =>
                    src.AlbumSongs != null ? src.AlbumSongs.Select(albumsong => albumsong.Song) : null));

            CreateMap<AlbumDto, Album>()
                .ForMember(dest => dest.Artist, opt => opt.Ignore())
                .ForMember(dest => dest.ArtistId, opt => opt.MapFrom(src => (src.ArtistId == 0) ? (int?)null : src.ArtistId));

            CreateMap<Song, SongDto>()
                .ForMember(dest => dest.Artist, opt =>
                    opt.MapFrom(src => src.Artist ?? DeletedArtist));

            CreateMap<SongDto, Song>()
                .ForMember(dest => dest.Artist, opt => opt.Ignore())
                .ForMember(dest => dest.ArtistId, opt => opt.MapFrom(src => (src.ArtistId == 0) ? (int?)null : src.ArtistId));

            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();

            CreateMap<Playlist, PlaylistDto>()
                .ForMember(dest => dest.Songs, opt => opt.MapFrom(src =>
                    src.PlaylistSongs != null ? src.PlaylistSongs.Select(playlistsong => playlistsong.Song) : null));

            CreateMap<PlaylistDto, Playlist>()
                .ForMember(dest => dest.User, opt => opt.Ignore());

            CreateMap<Like, LikeDto>();
            CreateMap<LikeDto, Like>();
        }
    }
}
