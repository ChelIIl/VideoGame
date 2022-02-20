using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoGame.Context;
using VideoGame.Models;

namespace VideoGame.Services
{
    public class GameServices : IGameServices
    {
        private ApplicationDbContext db;

        public GameServices(ApplicationDbContext _db)
        {
            db = _db;
        }

        [HttpPut]
        public void CreateGame(Game game)
        {
            if (game != null)
            {
                db.Add(game);
                db.SaveChanges();
            }
        }

        public void DeleteGame(int id)
        {
            Game game = db.Games.FirstOrDefault(g => g.Id == id);
            if (game != null)
            {
                db.Remove(game);
                db.SaveChanges();
            }
        }
        [HttpGet]
        public IEnumerable<Game> GetAllGames()
        {
            return db.Games.Select(g => g).ToList();
        }
        [HttpGet("{id}")]
        public Game GetGame(int id)
        {
            return db.Games.FirstOrDefault(g => g.Id == id);
        }

        public IEnumerable<Game> GetGameByGenre(string genre)
        {
            throw new NotImplementedException();
        }

        public void UpdateGame(Game game)
        {
            db.Update(game);
            db.SaveChanges();
        }
    }
}
