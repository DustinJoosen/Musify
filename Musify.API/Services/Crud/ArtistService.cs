using AutoMapper;
using Musify.API.Data;
using Musify.API.Models;
using Musify.Infra.Dtos;

namespace Musify.API.Services
{
    public class ArtistService : CrudService<Artist, ArtistDto>, IArtistService
    {
        public ArtistService(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
       
    }
}
