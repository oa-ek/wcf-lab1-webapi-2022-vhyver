using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRepository.DTO
{
	public class UserReadDTO
	{
		public string Id { get; set; }
		public string FullName { get; set; }
		public string Email { get; set; }
		public bool IsConfirmed { get; set; }
		public List<IdentityRole>? Roles { get; set; }
	}
}
