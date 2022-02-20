using Microsoft.AspNetCore.Mvc;
using VideoGame.Context;
using VideoGame.Models;

namespace VideoGame.Services
{
    public class GameServices
    {
        ApplicationDbContext db;
        public GameServices(ApplicationDbContext _db)
        {
            db = _db;
        }

        [HttpGet]
        public IEnumerable<Game> GetAll()
        {
            return (db.Games.Select(g => g).ToList());
        }

        [HttpGet("{id}")]
        public IEnumerable<Game> Get(int id)
        {
            yield return (db.Games.FirstOrDefault(g => g.Id == id));
        }
    }
}
