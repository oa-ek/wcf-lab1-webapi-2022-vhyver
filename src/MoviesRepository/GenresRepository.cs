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
    public class GenresRepository
    {
        private readonly MoviesDbContext _ctx;
        private readonly IMapper _mapper;
        public GenresRepository(MoviesDbContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GenresDto>> GetGenresAsync()
        {
            return _mapper.Map<IEnumerable<GenresDto>>(await _ctx.Genres.ToListAsync());
        }

        public List<Genre> GetGenres()
        {
            return _ctx.Genres.ToList();
        }

    }
}
  
