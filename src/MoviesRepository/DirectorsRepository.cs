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
    public class DirectorsRepository
    {
        private readonly MoviesDbContext _ctx;
        private readonly IMapper _mapper;
        public DirectorsRepository(MoviesDbContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        //GET ALL
        public async Task<IEnumerable<DirectorsDto>> GetDirectorsAsync()
        {
            return _mapper.Map<IEnumerable<DirectorsDto>>(await _ctx.Directors.ToListAsync());
        }

        //CREATE

        //DELETE
        public async Task DeleteDirector(int id)
        {
            _ctx.Directors.Remove(_ctx.Directors.Find(id));
            _ctx.SaveChanges();
        }
    }
}
