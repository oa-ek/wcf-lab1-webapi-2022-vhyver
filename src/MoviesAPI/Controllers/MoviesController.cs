using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesCore;
using MoviesShared;
using MoviesShared.DTO;

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
        public async Task<IEnumerable<MoviesDto>> GetListAsync()
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
