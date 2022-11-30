using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShared.DTO
{
	public class UsersDTO
	{
		public string Id { get; set; }
		public string FullName { get; set; }
		public string Email { get; set; }
		public bool IsConfirmed { get; set; }
		public List<IdentityRole>? Roles { get; set; }
	}
}
