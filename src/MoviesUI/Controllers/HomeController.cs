using Microsoft.AspNetCore.Mvc;
using MoviesCore;
using MoviesUI.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace MoviesUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly MoviesDbContext dbContext;
        public HomeController(MoviesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {   
            // genre query | set to dropdown menu
            var drama = from x in dbContext.Movies
                        where x.Genres.Any(x => x.GenreName == "Drama")
                        select x;
            return View(drama.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
            
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}