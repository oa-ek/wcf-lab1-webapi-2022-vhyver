using MoviesCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRepository
{
    public class ActorsRepository
    {
        private readonly MoviesDbContext _ctx;
        public ActorsRepository(MoviesDbContext ctx)
        {
            _ctx = ctx;
        }

        public List<Actor> GetAllActors()
        {
            return _ctx.Actors.ToList();
        }
    }
}
