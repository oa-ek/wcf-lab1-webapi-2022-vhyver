using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MoviesCore;
using MoviesShared.DTO.Actors;
using MoviesShared.DTO.Genres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security;
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
        public async Task<IEnumerable<ActorsReadDto>> GetActorsAsync()
        {
            return _mapper.Map<IEnumerable<ActorsReadDto>>(await _ctx.Actors.ToListAsync());
        }

        //CREATE
        public async Task<int> AddActor(ActorsCreateUpdateDto actor)
        {
            var data = await _ctx.Actors.AddAsync(_mapper.Map<Actor>(actor));
            await _ctx.SaveChangesAsync();
            return data.Entity.Id;
        }

        //EDIT
        public async Task<int> UpdateActor(ActorsReadDto newActor)
        {
            var actorInDB = _ctx.Actors.FirstOrDefault(x => x.Id == newActor.Id);
            actorInDB.FirstName = newActor.FirstName;
            actorInDB.LastName = newActor.LastName;
            await _ctx.SaveChangesAsync();

            var data = _mapper.Map<ActorsReadDto>(actorInDB);
            return data.Id;
        }
        //DELETE
        public async Task DeleteActor(int id)
        {
            _ctx.Actors.Remove(_ctx.Actors.Find(id));
            _ctx.SaveChanges();
        }
    }
}
