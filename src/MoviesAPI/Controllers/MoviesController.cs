using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesCore;
using MoviesShared;
using MoviesShared.DTO.Genres;
using MoviesShared.DTO.Movies;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MoviesRepository moviesRepository;
        public MoviesController(MoviesRepository moviesRepository) 
        {
            this.moviesRepository = moviesRepository;
        }

        /// <summary>
        /// Returns async list of movies from repository
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<MoviesReadDto>> GetListAsync()
        {
            return await moviesRepository.GetMoviesAsync();
        }

        /// <summary>
        /// Get movie by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            return await moviesRepository.GetMovie(id);
        }

        /// <summary>
        /// Create movie
        /// </summary>
        /// <param name="dto"></param>
        [HttpPost("new")]
        public async Task<int> AddMovie(MoviesCreateUpdateDto dto)
        {
            return await moviesRepository.AddMovie(dto);
        }
        //edit

        /// <summary>
        /// Delete movie by id
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await moviesRepository.DeleteMovie(id);
        }
    }
}
