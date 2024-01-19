using AutoMapper;
using Musify.API.Models;
using Musify.Infra.Dtos;

namespace Musify.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Artist, ArtistDto>();
            CreateMap<ArtistDto, Artist>();

            CreateMap<Album, AlbumDto>();
            CreateMap<AlbumDto, Album>();

            CreateMap<Song, SongDto>();
            CreateMap<SongDto, Song>();

            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();

            CreateMap<Playlist, PlaylistDto>();
            CreateMap<PlaylistDto, Playlist>();
        }
    }
}
