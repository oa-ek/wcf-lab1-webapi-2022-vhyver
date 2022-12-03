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

        //GET ALL
        public async Task<IEnumerable<ActorsDto>> GetActorsAsync()
        {
            return _mapper.Map<IEnumerable<ActorsDto>>(await _ctx.Actors.ToListAsync());
        }
        //CREATE
        
        //DELETE
        public async Task DeleteActor(int id)
        {
            _ctx.Actors.Remove(_ctx.Actors.Find(id));
            _ctx.SaveChanges();
        }
    }
}
