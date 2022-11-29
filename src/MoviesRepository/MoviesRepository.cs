using MoviesCore;
using System.Diagnostics.CodeAnalysis;

namespace MoviesRepository
{
    public class MoviesRepository
    {
        private readonly MoviesDbContext _ctx;

        public MoviesRepository(MoviesDbContext ctx)
        {
            _ctx = ctx;
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
