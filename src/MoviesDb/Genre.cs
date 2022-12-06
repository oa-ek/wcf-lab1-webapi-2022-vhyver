using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MoviesCore
{
    public class Genre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? GenreName { get; set; }

        [JsonIgnore]
        public virtual ICollection<Movie>? Movies { get; set; } = new List<Movie>();

        public override string ToString()
        {
            return $"{GenreName} ";
        }
    }
}
