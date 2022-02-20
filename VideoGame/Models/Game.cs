using System.ComponentModel.DataAnnotations;

namespace VideoGame.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public DateTime Dadd { get; set; } = DateTime.Now;
        public string? Game_name { get; set; }
        public Studio Studio { get; set; }
        public bool Game_act { get; set; } = true;
    }
}
