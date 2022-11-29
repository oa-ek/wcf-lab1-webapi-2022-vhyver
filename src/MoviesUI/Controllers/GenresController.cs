using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesRepository;
using Microsoft.EntityFrameworkCore;
using MoviesCore;

namespace MoviesUI.Controllers
{
    public class GenresController : Controller
    {

        private readonly MoviesDbContext dbContext;
        public GenresController(MoviesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public ActionResult Index()
        {
            return View(dbContext.Genres?.ToList());
        }

        public ActionResult FilteredList(int id)
        {
            var query = from x in dbContext.Movies
                        where x.Genres.Any(x => x.Id == id)
                        select x;
            ViewBag.Genre = dbContext.Genres?.FirstOrDefault(x => x.Id == id)?.GenreName;
            return View(query.Include(x => x.Genres).Include(x => x.Type).ToList());
        }

    }
}
