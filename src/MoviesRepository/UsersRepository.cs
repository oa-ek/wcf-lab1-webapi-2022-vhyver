using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MoviesCore;
using MoviesShared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesShared;
using Microsoft.AspNetCore.Identity;
using AutoMapper;

namespace MoviesShared
{
	public class UsersRepository
	{
        private readonly MoviesDbContext _ctx;
		private readonly UserManager<User> userManager;
		private readonly RoleManager<IdentityRole> roleManager;
        private readonly IMapper _mapper;
        public UsersRepository(MoviesDbContext ctx, UserManager<User> userManager, RoleManager<IdentityRole> roleManager, IMapper mapper)
		{
			_ctx = ctx;
			this.userManager = userManager;
			this.roleManager = roleManager;
			_mapper = mapper;
		}

		//GET ALL
        public async Task<IEnumerable<UsersDto>> GetUsersAsync()
        {
            return _mapper.Map<IEnumerable<UsersDto>>(await _ctx.Users.ToListAsync());
        }

        //DELETE
        public async Task DeleteUser(int id)
        {
            _ctx.Users.Remove(_ctx.Users.Find(id));
            _ctx.SaveChanges();
        }
    }
}
