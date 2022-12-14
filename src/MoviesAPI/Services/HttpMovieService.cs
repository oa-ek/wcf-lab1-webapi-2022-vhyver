using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using MoviesShared.DTO.Movies;

namespace MoviesAPI.Services
{
    public class HttpMovieService : HttpBaseService
    {
        public HttpMovieService(HttpClient httpClient)
           : base(httpClient) { }

        public async Task<IEnumerable<MoviesReadDto>> GetMoviesAsync()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<MoviesReadDto>>("https:/localhost:7119/api/movies");
        }
        public async Task<MoviesReadDto> GetAsync(int id)
        {
            return await httpClient.GetFromJsonAsync<MoviesReadDto>($"/api/movies/{id}");
        }
    }
}
