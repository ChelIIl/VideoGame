using System.ComponentModel.DataAnnotations;

namespace VideoGame.Models
{
    public class GameGenre
    {
        [Key]
        public int Id { get; set; }
        public DateTime Dadd { get; set; } = DateTime.Now;
        public Game Game { get; set; }
        public Genre Genre { get; set; }
        public bool Genre_act { get; set; } = true;
    }
}
