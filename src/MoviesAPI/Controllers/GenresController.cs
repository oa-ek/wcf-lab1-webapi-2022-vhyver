using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesShared;
using Microsoft.EntityFrameworkCore;
using MoviesCore;
using MoviesShared.DTO.Genres;

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
        /// Returns async list of genres from repository
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<GenresReadDto>> GetListAsync()
        {
            return await genresRepository.GetGenresAsync();
        }

        /// <summary>
        /// Create genre
        /// </summary>
        /// <param name="name"></param>
        [HttpPost]
        public async Task<int> AddGenre(GenresCreateUpdateDto dto)
        {
            return await genresRepository.AddGenre(dto);
        }

        /// <summary>
        /// Delete genre by id
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await genresRepository.DeleteGenre(id);
        }
    }
}
