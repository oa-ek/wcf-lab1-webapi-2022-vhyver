using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MoviesCore;
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

        //EDIT

        //DELETE
        public async Task DeleteMovie(int id)
        {
            _ctx.Movies.Remove(_ctx.Movies.Find(id));
            _ctx.SaveChanges();
        }
    }
}
