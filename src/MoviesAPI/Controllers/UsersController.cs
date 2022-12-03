using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesCore;
using MoviesShared;
using MoviesShared.DTO;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UsersRepository usersRepository;
        public UsersController(UsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }
        /// <summary>
        /// Get List of all users
        /// </summary>
        /// <returns>List of Users</returns>
        [HttpGet]
        public async Task<IEnumerable<UsersDto>> GetListAsync()
        {
            return await usersRepository.GetUsersAsync();
        }

        /// <summary>
        /// Delete user by id
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await usersRepository.DeleteUser(id);
        }
    }
}
