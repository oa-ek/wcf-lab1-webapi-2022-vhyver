using MoviesCore;
using MoviesShared.DTO.Genres;
using MoviesShared.DTO.Publishers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShared.DTO.Movies
{
    public class MoviesReadDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? PosterPath { get; set; }
        public float? Rating { get; set; }
        public int ReleaseYear { get; set; }
        public int Duration { get; set; }
        public PublishersReadDto? Country { get; set; }
        public ICollection<GenresReadDto>? Genres { get; set; } = new List<GenresReadDto>();
    }
}
