using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MoviesCore;
using MoviesShared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShared
{
    public class ActorsRepository
    {
        private readonly MoviesDbContext _ctx;
        private readonly IMapper _mapper;
        public ActorsRepository(MoviesDbContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ActorsDto>> GetActorsAsync()
        {
            return _mapper.Map<IEnumerable<ActorsDto>>(await _ctx.Actors.ToListAsync());
        }
        public List<Actor> GetAllActors()
        {
            return _ctx.Actors.ToList();
        }
    }
}
