using System.ComponentModel.DataAnnotations;

namespace VideoGame.Models
{
    public class Studio
    {
        [Key]
        public int Id { get; set; }
        public DateTime Dadd { get; set; } = DateTime.Now;
        public string? Studio_name { get; set; }
        public bool Studio_act { get; set; } = true;

        public override string ToString()
        {
            return this.Studio_name;
        }
    }
}
