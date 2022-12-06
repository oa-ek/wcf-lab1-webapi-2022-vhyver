using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MoviesCore;
using MoviesShared.DTO.Genres;
using MoviesShared.DTO.Publishers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShared
{
    public class PublishersRepository
    {
        private readonly MoviesDbContext _ctx;
        private readonly IMapper _mapper;
        public PublishersRepository(MoviesDbContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        //GET ALL
        public async Task<IEnumerable<PublishersReadDto>> GetPublishersAsync()
        {
            return _mapper.Map<IEnumerable<PublishersReadDto>>(await _ctx.PublisherCountries.ToListAsync());
        }

        //CREATE
        public async Task<int> AddPublisher(PublishersCreateUpdateDto publisher)
        {
            var data = await _ctx.PublisherCountries.AddAsync(_mapper.Map<PublisherCountry>(publisher));
            await _ctx.SaveChangesAsync();
            return data.Entity.Id;
        }
        //DELETE
        public async Task DeletePublisher(int id)
        {
            _ctx.PublisherCountries.Remove(_ctx.PublisherCountries.Find(id));
            await _ctx.SaveChangesAsync();
        }
    }
}
