using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesShared.DTO;
using MoviesShared;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly GenresRepository genresRepository;
        public GenresController(GenresRepository genresRepository)
        {
            this.genresRepository = genresRepository;
        }

        /// <summary>
        /// Returns async list of genresfrom repository
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<GenresDto>> GetListAsync()
        {
            return await genresRepository.GetGenresAsync();
        }
    }
}
