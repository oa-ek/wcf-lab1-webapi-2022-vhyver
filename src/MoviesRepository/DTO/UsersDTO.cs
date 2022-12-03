using Microsoft.AspNetCore.Identity;
using MoviesCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShared.DTO
{
	public class UsersDto
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
