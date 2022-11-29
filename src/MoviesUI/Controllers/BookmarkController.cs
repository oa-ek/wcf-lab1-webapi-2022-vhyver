using Microsoft.AspNetCore.Mvc;
using MoviesCore;
using MoviesUI.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace MoviesUI.Controllers
{
    public class BookmarkController : Controller
    {
        private readonly MoviesDbContext dbContext;
        public BookmarkController(MoviesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var currentUser = dbContext.Users.Include(x => x.Movies).FirstOrDefault(x => x.UserName == User.Identity.Name);
            if (currentUser != null)
            {
                return View(currentUser.Movies?.ToList());
            }
            return View();
        }
        public ActionResult Remove(int id)
        {
            var currentUser = dbContext.Users.Include(x => x.Movies).FirstOrDefault(x => x.UserName == User.Identity.Name);
            currentUser?.Movies?.Remove(currentUser.Movies.FirstOrDefault(x => x.Id == id));
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
