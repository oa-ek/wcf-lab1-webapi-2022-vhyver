using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MoviesCore;
using MoviesShared.DTO;
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

        public async Task<IEnumerable<MoviesDto>> GetMoviesAsync()
        {
            return _mapper.Map<IEnumerable<MoviesDto>>( await _ctx.Movies.ToListAsync());
        }
        public List<Movie> GetAllMovies()
        {
            return _ctx.Movies.ToList();
        }

        public Movie GetMovieById(int ID)
        {
            return _ctx.Movies.FirstOrDefault(x => x.Id == ID);
        }

    }
}
