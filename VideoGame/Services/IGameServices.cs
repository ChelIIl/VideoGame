using VideoGame.Models;

namespace VideoGame.Services
{
    public interface IGameServices
    {
        public IEnumerable<Game> GetAllGames();
        public Game GetGame(int id);
        public IEnumerable<Game> GetGameByGenre(string genre);
        public void DeleteGame(int id);
        public void CreateGame(Game game);
        public void UpdateGame(Game game);
    }
}
