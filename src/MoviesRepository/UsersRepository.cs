using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MoviesCore;
using MoviesRepository.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRepository
{
	public class UsersRepository
	{
        private readonly MoviesDbContext _ctx;
		private readonly UserManager<User> userManager;
		private readonly RoleManager<IdentityRole> roleManager;
		public UsersRepository(MoviesDbContext ctx, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
		{
			_ctx = ctx;
			this.userManager = userManager;
			this.roleManager = roleManager;
		}

        public async Task<IEnumerable<UsersDTO>> GetAllUsers()
        {
			var users = new List<UsersDTO>();
			foreach(var u in _ctx.Users.ToList())
			{
				var userDTO = new UsersDTO
				{
					Id = u.Id,
					Email = u.Email,
					FullName = $"{u.LastName} {u.FirstName}",
					IsConfirmed = u.EmailConfirmed,
					Roles = new List<IdentityRole>()
				};
				foreach(var role in await userManager.GetRolesAsync(u))
				{
					userDTO.Roles.Add(await _ctx.Roles.FirstAsync(x => x.Name.ToLower() == role.ToLower()));
				}
				users.Add(userDTO);
			}
            return users;
        }
    }
}
