using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoGame.Context;
using VideoGame.Services;
using VideoGame.Models;

namespace VideoGame.Controllers
{
    public class GameController : Controller
    {
        IGameServices gs;

        public GameController(IGameServices _gs)
        {
            gs = _gs;
        }

        public IActionResult Index()
        {
            return View(gs.GetAllGames());
        }

        public IActionResult Get(int id)
        {
            return Ok(gs.GetGame(id));
        }

        public IActionResult Delete(int id)
        {
            gs.DeleteGame(id);
            return View("Index", gs.GetAllGames());
        }
         

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Game game)
        {
            gs.CreateGame(game);
            return View("Index", gs.GetAllGames());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(gs.GetGame(id));
        }

        [HttpPost]
        public IActionResult Edit(Game game)
        {
            gs.UpdateGame(game);
            return View("Index", gs.GetAllGames());
        }
    }
}
