using System.Drawing;

namespace Watchers.Models
{
    public class Movie
    {
        public string Name { get; set; }
        public string MovieID { get; set; }
        public string Description { get; set; }
        public Image MovieImage { get; set; }
        public int CinemaNumber { get; set; }
    }
}
