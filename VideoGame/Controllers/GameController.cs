using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoGame.Context;
using VideoGame.Models;

namespace VideoGame.Controllers
{
    public class GameController : Controller
    {
        ApplicationDbContext db;
        public GameController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var games = db.Games.Include(g => g.Studio);

            return View(games.ToList());
        }

        //public IActionResult GetAll()
        //{
        //    IEnumerable<Game> games = db.Games.Select(g => g).ToList();

        //    return View(games);
        //}

        //[HttpGet("{id}")]
        //public IActionResult Get(int id)
        //{
        //    Game game = db.Games.FirstOrDefault(g => g.Id == id);

        //    if(game == null)
        //    {
        //        return View("Index");
        //    }
        //    else
        //    {
        //        return View(game);
        //    }
        //}
    }
}
