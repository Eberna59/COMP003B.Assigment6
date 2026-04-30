using COMP003B.Assigment6.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.Assigment6.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie>Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }

        public DbSet<MovieActor> MovieActors { get; set; }
    }
}
