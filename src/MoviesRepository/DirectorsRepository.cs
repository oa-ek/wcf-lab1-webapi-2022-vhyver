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
        public async Task<IEnumerable<DirectorsDto>> GetDirectorsAsync()
        {
            return _mapper.Map<IEnumerable<DirectorsDto>>(await _ctx.Directors.ToListAsync());
        }

        public List<Director> GetAllActors()
        {
            return _ctx.Directors.ToList();
        }
    }
}
