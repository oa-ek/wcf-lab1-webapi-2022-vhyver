using Microsoft.AspNetCore.Identity;
namespace MoviesCore

{
    public class User : IdentityUser
    {
        public string? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public bool IsConfirmed { get; set; }
        public List<IdentityRole>? Roles { get; set; }
        public List<Movie>? Movies { get; set; }
    }
}