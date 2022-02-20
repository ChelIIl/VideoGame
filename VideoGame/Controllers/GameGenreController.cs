using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using VideoGame.Context;
using VideoGame.Services;

namespace VideoGame.Controllers
{
    public class GameGenreController : Controller
    {
        IGameGenreServices ggserv;
        ApplicationDbContext db;

        public GameGenreController(IGameGenreServices _ggserv, ApplicationDbContext _db)
        {
            ggserv = _ggserv;
            db = _db;
        }

        public IActionResult Index()
        {
            var genres = db.Genres.Select(g => g.Genre_name).ToList();

            ViewBag.Genres = genres;

            return View(ggserv.GetAllGameGenres());
        }
    }
}
