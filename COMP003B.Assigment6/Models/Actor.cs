using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assigment6.Models
{
    public class Actor
    {
        public int ActorID { get; set; }

        [Required]

        public string Name { get; set; }

        public int Age { get; set; }

        public virtual ICollection<MovieActor>? MovieActors { get; set; }
    }
}
