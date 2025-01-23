using System.Data.Entity;

namespace MvcStoredProcedureSample.Models
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext() : base("name = MovieDbContext")
        {
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().MapToStoredProcedures();
        }

    }
}