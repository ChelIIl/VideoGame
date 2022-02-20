using VideoGame.Models;

namespace VideoGame.Services
{
    public interface IGameGenreServices
    {
        public void NewGameGenre(GameGenre gameGenre);
        public void DeleteGameGenre(GameGenre gameGenre);
        public void UpdateGameGenre(GameGenre gameGenre);
        public IEnumerable<GameGenre> GetAllGameGenres();
        public IEnumerable<GameGenre> GetGameGenre(int id);
        public IEnumerable<GameGenre> GetGameByGenre(int id);
    }
}
