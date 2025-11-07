using Microsoft.EntityFrameworkCore;
using MVC_CodeFirst.Models.Entities;

namespace MVC_CodeFirst.Context
{
    public class MovieContext:DbContext
    {

        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-J4PTH70;Database=MVC_MovieDB;User Id=sa;Password=123;TrustServerCertificate=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }

    }
}
