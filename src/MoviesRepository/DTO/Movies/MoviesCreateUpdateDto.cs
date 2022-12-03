using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShared.DTO.Movies
{
    public class MoviesCreateUpdateDto
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? PosterPath { get; set; }
        public float? Rating { get; set; }
        public int ReleaseYear { get; set; }
        public int Duration { get; set; }
        public int CountryId { get; set; }
        public int[]? Genres { get; set; }
    }
}
