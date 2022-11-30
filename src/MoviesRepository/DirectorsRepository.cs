using MoviesCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShared
{
    public class DirectorsRepository
    {
        private readonly MoviesDbContext _ctx;
        public DirectorsRepository(MoviesDbContext ctx)
        {
            _ctx = ctx;
        }

        public List<Director> GetAllActors()
        {
            return _ctx.Directors.ToList();
        }
    }
}
