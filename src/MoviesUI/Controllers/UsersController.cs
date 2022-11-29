using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MoviesRepository;

namespace MoviesUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UsersController : Controller
	{
        private readonly UsersRepository userRepository;

		public UsersController(UsersRepository userRepository)
		{
			this.userRepository = userRepository;
		}
		public async Task<IActionResult> Index()
		{
			return View(await userRepository.GetAllUsers());
		}
	}
}
