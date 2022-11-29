using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesCore
{
    public class Type
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? TypeName { get; set; }
        public virtual ICollection<Movie>? Movies { get; set; } = new List<Movie>();
        public override string ToString()
        {
            return $"{TypeName}";
        }
    }
}
