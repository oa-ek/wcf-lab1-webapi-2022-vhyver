using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MoviesCore;
using MoviesShared.DTO.Actors;
using MoviesShared.DTO.Directors;
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
        public async Task<IEnumerable<DirectorsReadDto>> GetDirectorsAsync()
        {
            return _mapper.Map<IEnumerable<DirectorsReadDto>>(await _ctx.Directors.ToListAsync());
        }

        //CREATE
        public async Task<int> AddDirector(DirectorsCreateUpdateDto director)
        {
            var data = await _ctx.Directors.AddAsync(_mapper.Map<Director>(director));
            await _ctx.SaveChangesAsync();
            return data.Entity.Id;
        }

        //DELETE
        public async Task DeleteDirector(int id)
        {
            _ctx.Directors.Remove(_ctx.Directors.Find(id));
            _ctx.SaveChanges();
        }
    }
}
