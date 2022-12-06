using AutoMapper;
using MoviesCore;
using MoviesShared.DTO;
using MoviesShared.DTO.Actors;
using MoviesShared.DTO.Directors;
using MoviesShared.DTO.Genres;
using MoviesShared.DTO.Movies;
using MoviesShared.DTO.Publishers;

namespace MoviesAPI
{
    public class AppAutoMapper : Profile
    {
        public AppAutoMapper()
        {
            CreateMap<MoviesReadDto, Movie>();
            CreateMap<Movie, MoviesReadDto>();
            CreateMap<MoviesCreateUpdateDto, Movie>();
            CreateMap<Movie, MoviesCreateUpdateDto>();

            CreateMap<GenresReadDto, Genre>();
            CreateMap<Genre, GenresReadDto>();
            CreateMap<GenresCreateUpdateDto, Genre>();
            CreateMap<Genre, GenresCreateUpdateDto>();

            CreateMap<ActorsReadDto, Actor>();
            CreateMap<Actor, ActorsReadDto>();
            CreateMap<ActorsCreateUpdateDto, Actor>();
            CreateMap<Actor, ActorsCreateUpdateDto>();

            CreateMap<DirectorsReadDto, Director>();
            CreateMap<Director, DirectorsReadDto>();
            CreateMap<DirectorsCreateUpdateDto, Director>();
            CreateMap<Director, DirectorsCreateUpdateDto>();

            CreateMap<UsersDto, User>();
            CreateMap<User, UsersDto>();

            CreateMap<PublisherCountry, PublishersReadDto>();
            CreateMap<PublishersReadDto, PublisherCountry>();
            CreateMap<PublisherCountry, PublishersCreateUpdateDto>();
            CreateMap<PublishersCreateUpdateDto, PublisherCountry>();
        }
    }
}
