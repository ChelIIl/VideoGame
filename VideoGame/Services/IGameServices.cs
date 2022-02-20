using VideoGame.Models;

namespace VideoGame.Services
{
    public interface IGameServices
    {
        public IEnumerable<Game> GetAllGames();
        public IEnumerable<Game> GetGame(int id);
        public IEnumerable<Game> GetGameByGenre(string genre);
    }
}
