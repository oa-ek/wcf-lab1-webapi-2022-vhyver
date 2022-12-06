using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MoviesCore;
using MoviesShared.DTO.Genres;
using MoviesShared.DTO.Movies;
using System.Diagnostics.CodeAnalysis;

namespace MoviesShared
{
    public class MoviesRepository
    {
        private readonly MoviesDbContext _ctx;
        private readonly IMapper _mapper;

        public MoviesRepository(MoviesDbContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        //GET ALL
        public async Task<IEnumerable<MoviesReadDto>> GetMoviesAsync()
        {
            return _mapper.Map<IEnumerable<MoviesReadDto>>(await _ctx.Movies.Include(x => x.Country).ToListAsync());
        }

        //GET ONE
        public async Task<Movie> GetMovie(int id)
        {
            var movie = _ctx.Movies?.Include(x => x.Directors).Include(x => x.Actors).
                Include(x => x.Genres).Include(x => x.Country).Include(x => x.Type).FirstOrDefault(x => x.Id == id);

            return movie;
        }

        //CREATE
        public async Task<int> AddMovie(MoviesCreateUpdateDto movie)
        {
            var newMovie = new Movie
            {
                Title = movie.Title,
                Description = movie.Description,
                PosterPath = movie.PosterPath,
                Rating = movie.Rating,
                ReleaseYear = movie.ReleaseYear,
                Duration = movie.Duration,
            };
            if (movie.Genres != null)
            {
                newMovie.Genres = new List<Genre>();
                foreach (var g in _ctx.Genres.Where(ge => movie.Genres.Contains(ge.Id)))
                {
                    newMovie.Genres.Add(g);
                }
            }
            if (movie.CountryId != 0) newMovie.Country = _ctx.PublisherCountries.FirstOrDefault(x => x.Id == movie.CountryId);
            
            _ctx.Movies?.Add(newMovie);
            await _ctx.SaveChangesAsync();
            return newMovie.Id;
        }
        //EDIT

        //DELETE
        public async Task DeleteMovie(int id)
        {
            _ctx.Movies.Remove(_ctx.Movies.Find(id));
            _ctx.SaveChanges();
        }
    }
}
