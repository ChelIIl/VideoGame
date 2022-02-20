using VideoGame.Models;
using VideoGame.Context;
using Microsoft.EntityFrameworkCore;

namespace VideoGame.Services
{
    public class GameGenreServices : IGameGenreServices
    {
        ApplicationDbContext db;

        public GameGenreServices(ApplicationDbContext _db)
        {
            db = _db;
        }

        public void DeleteGameGenre(GameGenre gameGenre)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GameGenre> GetAllGameGenres()
        {
            return (db.GameGenres.Include(gg => gg.Game).Include(gg => gg.Genre).Select(gg => gg).ToList());
        }

        public IEnumerable<GameGenre> GetGameByGenre(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GameGenre> GetGameGenre(int id)
        {
            throw new NotImplementedException();
        }

        public void NewGameGenre(GameGenre gameGenre)
        {
            throw new NotImplementedException();
        }

        public void UpdateGameGenre(GameGenre gameGenre)
        {
            throw new NotImplementedException();
        }
    }
}
