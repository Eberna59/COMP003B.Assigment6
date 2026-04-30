using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assigment6.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required]
        public string Title { get; set; }

        public int Year { get; set; }

        public virtual ICollection<MovieActor>? MovieActors { get; set; }

        public int Genre {  get; set; }
    }
}
