

using CA_ServicePattern.Entities;
using CA_ServicePattern.Seeds;
using Microsoft.EntityFrameworkCore;

namespace CA_ServicePattern.Context
{
    public class CodeFirstContext:DbContext
    {
        //Class'lar veritabanında tablo haline gelecek.

        //DbSet<>
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        //ConnectionString
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-J4PTH70;Database=ServicePattern;User Id=sa;Password=123;TrustServerCertificate=True;");
            }

            base.OnConfiguring(optionsBuilder);
        }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {

                //Category Seeder
                modelBuilder.Entity<Category>()
                    .HasData(CategorySeeder.categories);

            //Supplier Seeder
            modelBuilder.Entity<Supplier>()
               .HasData(SupplierSeeder.Suppliers);

            //Product Seeder
            modelBuilder.Entity<Product>()
                    .HasData(ProductSeeder.products);

           

                base.OnModelCreating(modelBuilder);
            }

    }
}
