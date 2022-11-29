using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MoviesCore;
using MoviesRepository;
using System.Diagnostics;

namespace MoviesUI.Controllers
{
    [Authorize]
    public class MoviesController : Controller
    {
        private readonly MoviesDbContext dbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public MoviesController(MoviesDbContext dbContext, IWebHostEnvironment webHostEnvironment)
        {
            this.dbContext = dbContext;
            _webHostEnvironment = webHostEnvironment;
        }
        // GET: MovieController
        public ActionResult Index()
        {
            var MoviesWithEv = dbContext.Movies
                .Include(x => x.Genres)
                .Include(x => x.Country)
                .Include(x => x.Type)
                .ToList();

            return View(MoviesWithEv);
        }
        [HttpGet]
        public async Task<IActionResult> Index(string movieSearch)
        {
            ViewData["GetMoviesDetails"] = movieSearch;

            var mquery = from x in dbContext.Movies select x;
            if (!String.IsNullOrEmpty(movieSearch))
            {
                mquery = mquery.Where(x => x.Title.Contains(movieSearch));
            }
            return View(await mquery.Include(x => x.Genres).ToListAsync());
        }
        // GET: MovieController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var movie = dbContext.Movies
                .Include(x => x.Directors)
                .Include(x => x.Actors)
                .Include(x => x.Genres)
                .Include(x => x.Country)
                .Include(x => x.Type)
                .FirstOrDefault(x => x.Id == id);
            if (movie == null) return NotFound();

            return View(movie);
        }

        // GET: MovieController/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Genres = dbContext.Genres.ToList();
            ViewBag.Types = dbContext.Types.ToList();
            ViewBag.Contries = dbContext.PublisherCountries.ToList();
            return View();
        }

        // POST: MovieController/Create
        [HttpPost]
        public ActionResult Create(Movie movie, int[] selectedGenres, int selectedType, int selectedCountry, IFormFile Image)
        {

            if (selectedGenres != null)
            {
                movie.Genres = new List<Genre>();
                foreach (var g in dbContext.Genres.Where(ge => selectedGenres.Contains(ge.Id)))
                {
                    movie.Genres.Add(g);
                }
            }
            if (selectedType != 0)
            {
                movie.Type = dbContext.Types.FirstOrDefault(x => x.Id == selectedType);
            }
            if (selectedType != 0)
            {
                movie.Country = dbContext.PublisherCountries.FirstOrDefault(x => x.Id == selectedCountry);
            }
            if(movie.Type.TypeName == "Movie")
			{
                movie.Seasons = null;
			}
            string PicturePath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "posters", Image.FileName);
            using (FileStream stream = new FileStream(PicturePath, FileMode.Create))
                Image.CopyTo(stream);

            movie.PosterPath = Path.Combine("img", "posters", Image.FileName);
            dbContext.Movies.Add(movie);
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            Movie movie = dbContext.Movies.Include(x => x.Genres).FirstOrDefault(x => x.Id == id); ;
            if (movie == null) return NotFound();
            ViewBag.Genres = dbContext.Genres.ToList();
            return View(movie);
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        public ActionResult Edit(Movie movie, int[] selectedGenres)
        {

            Movie edited = dbContext.Movies.Include(x => x.Genres).FirstOrDefault(x => x.Id == movie.Id);
            edited.Title = movie.Title;
            edited.Description = movie.Description;
            edited.Rating = movie.Rating;
            edited.PosterPath = movie.PosterPath;
            edited.Duration = movie.Duration;
            edited.ReleaseYear = movie.ReleaseYear;

            edited.Genres.Clear();
            if (selectedGenres != null)
            {
                foreach (var g in dbContext.Genres.Where(ge => selectedGenres.Contains(ge.Id)))
                {
                    edited.Genres.Add(g);
                }
            }
            dbContext.Entry(edited).State = EntityState.Modified;
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public FileContentResult GetImage(int id)
        {
            var item = dbContext.Movies.Find(id);
            var path = Path.Combine(_webHostEnvironment.WebRootPath, item.PosterPath);
            var byteArray = System.IO.File.ReadAllBytes(path);
            return new FileContentResult(byteArray, "image/jpeg");
        }

        // GET: MovieController/Delete/5
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            return View(dbContext.Movies.Find(id));
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            dbContext.Movies.Remove(dbContext.Movies.Find(id));
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Bookmarked(int id)
        {
            var mov = dbContext.Movies.FirstOrDefault(x => x.Id == id);
            var currentUser = dbContext.Users.Include(x => x.Movies).FirstOrDefault(x => x.UserName == User.Identity.Name);
            if (mov != null && currentUser != null)
            {
                currentUser.Movies.Add(mov);
                dbContext.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
