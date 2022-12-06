using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesShared;
using MoviesShared.DTO.Actors;
using MoviesShared.DTO.Directors;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorsController : ControllerBase
    {
        private readonly DirectorsRepository directorsRepository;
        public DirectorsController(DirectorsRepository directorsRepository)
        {
            this.directorsRepository = directorsRepository;
        }

        /// <summary>
        /// Returns async list of directors from repository
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<DirectorsReadDto>> GetListAsync()
        {
            return await directorsRepository.GetDirectorsAsync();
        }

        /// <summary>
        /// Create director
        /// </summary>
        /// /// <param name="dto"></param>
        [HttpPost]
        public async Task<int> AddDirector(DirectorsCreateUpdateDto dto)
        {
            return await directorsRepository.AddDirector(dto);
        }

        /// <summary>
        /// Delete director by id
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await directorsRepository.DeleteDirector(id);
        }
    }
}
