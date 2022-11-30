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

            CreateMap<GenresDto, Genre>();
            CreateMap<Genre, GenresDto>();

            CreateMap<ActorsDto, Actor>();
            CreateMap<Actor, ActorsDto>();
        }
    }
}
