using AutoMapper;
using MoviesCore;
using MoviesShared.DTO;

namespace MoviesAPI
{
    public class AppAutoMapper : Profile
    {
        public AppAutoMapper()
        {
            CreateMap<MoviesDto, Movie>();
            CreateMap<Movie, MoviesDto>();
        }
    }
}
