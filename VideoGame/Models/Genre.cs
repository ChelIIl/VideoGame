using System.ComponentModel.DataAnnotations;

namespace VideoGame.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public DateTime Dadd { get; set; } = DateTime.Now;
        public string? Genre_name { get; set; }
        public bool Genre_act { get; set; } = true;

        public override string ToString()
        {
            return this.Genre_name;
        }
    }
}
