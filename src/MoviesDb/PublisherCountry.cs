using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesCore
{
    public class PublisherCountry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? CountryName { get; set; }

        public  virtual ICollection<Movie>? Movies { get; set; } = new List<Movie>();

        public override string ToString()
        {
            return $"{CountryName}";
        }
    }
}
