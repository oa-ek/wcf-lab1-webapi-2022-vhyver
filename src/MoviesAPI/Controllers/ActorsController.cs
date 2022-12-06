using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesShared;
using MoviesShared.DTO.Actors;
using MoviesShared.DTO.Genres;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        private readonly ActorsRepository actorsRepository;
        public ActorsController(ActorsRepository actorsRepository)
        {
            this.actorsRepository = actorsRepository;
        }

        /// <summary>
        /// Returns async list of actors from repository
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<ActorsReadDto>> GetListAsync()
        {
            return await actorsRepository.GetActorsAsync();
        }

        /// <summary>
        /// Create actor
        /// </summary>
        /// /// <param name="dto"></param>
        [HttpPost("new")]
        public async Task<int> AddActor(ActorsCreateUpdateDto dto)
        {
            return await actorsRepository.AddActor(dto);
        }

        /// <summary>
        /// Delete actor by id
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await actorsRepository.DeleteActor(id);
        }
    }
}
