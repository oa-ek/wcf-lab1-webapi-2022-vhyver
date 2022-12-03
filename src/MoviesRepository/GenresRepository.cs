using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MoviesCore;
using MoviesShared.DTO.Genres;
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

        //GET ALL
        public async Task<IEnumerable<GenresReadDto>> GetGenresAsync()
        {
            return _mapper.Map<IEnumerable<GenresReadDto>>(await _ctx.Genres.ToListAsync());
        }

        //CREATE
        public async Task<int> AddGenre(GenresCreateUpdateDto genre)
        {
            var data = await _ctx.Genres.AddAsync(_mapper.Map<Genre>(genre));
            await _ctx.SaveChangesAsync();
            return data.Entity.Id;
        }
        //DELETE
        public async Task DeleteGenre(int id)
        {
            _ctx.Genres.Remove(_ctx.Genres.Find(id));
            await _ctx.SaveChangesAsync();
        }
    }
}
  
