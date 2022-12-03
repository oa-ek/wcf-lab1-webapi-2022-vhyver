using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesShared.DTO;
using MoviesShared;

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
        public async Task<IEnumerable<ActorsDto>> GetListAsync()
        {
            return await actorsRepository.GetActorsAsync();
        }

        //create

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
