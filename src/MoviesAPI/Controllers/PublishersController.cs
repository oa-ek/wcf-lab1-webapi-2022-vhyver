using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesShared.DTO.Actors;
using MoviesShared;
using AutoMapper;
using MoviesCore;
using Microsoft.EntityFrameworkCore;
using MoviesShared.DTO.Publishers;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private readonly PublishersRepository publishersRepository;
        public PublishersController(PublishersRepository publishersRepository)
        {
            this.publishersRepository = publishersRepository;
        }
        /// <summary>
        /// Returns async list of publisher countries
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<PublishersReadDto>> GetListAsync()
        {
            return await publishersRepository.GetPublishersAsync();
        }

        /// <summary>
        /// Create publisher
        /// </summary>
        /// /// <param name="dto"></param>
        [HttpPost]
        public async Task<int> AddPublisher(PublishersCreateUpdateDto dto)
        {
            return await publishersRepository.AddPublisher(dto);
        }

        /// <summary>
        /// Delete publisher by id
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await publishersRepository.DeletePublisher(id);
        }
    }
}
