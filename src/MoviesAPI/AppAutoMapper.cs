using AutoMapper;
using MoviesCore;
using MoviesShared.DTO;
using MoviesShared.DTO.Genres;
using MoviesShared.DTO.Movies;

namespace MoviesAPI
{
    public class AppAutoMapper : Profile
    {
        public AppAutoMapper()
        {
            CreateMap<MoviesReadDto, Movie>();
            CreateMap<Movie, MoviesReadDto>();

            CreateMap<GenresReadDto, Genre>();
            CreateMap<Genre, GenresReadDto>();

            CreateMap<GenresCreateUpdateDto, Genre>();
            CreateMap<Genre, GenresCreateUpdateDto>();

            CreateMap<ActorsDto, Actor>();
            CreateMap<Actor, ActorsDto>();

            CreateMap<DirectorsDto, Director>();
            CreateMap<Director, DirectorsDto>();

            CreateMap<UsersDto, User>();
            CreateMap<User, UsersDto>();

            CreateMap<PublisherCountry, PublisherCountryDto>();
        }
    }
}
