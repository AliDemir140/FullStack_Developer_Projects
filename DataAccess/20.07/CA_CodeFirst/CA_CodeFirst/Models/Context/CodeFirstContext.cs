

using Microsoft.EntityFrameworkCore;
using CA_CodeFirst.Models.Entities;
using CA_CodeFirst.Models.Seeds;

namespace CA_CodeFirst.Models.Context
{
    public class CodeFirstContext : DbContext//bütün tabloları bünyesinde barındıran class.
    {

        //Veritabanında oluşturulmasını istediğimiz class'ları bu nesne içerisinde çağırmalıyız.

        //Table
        public DbSet<AppUser> Users { get; set; }
        public DbSet<AppUserDetail> UserDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentAndCourse> StudentAndCourses { get; set; }


        //veritabanı bilgisini barındırır.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {



            if (!optionsBuilder.IsConfigured)
            {
                //connectionstring yapılandırması.

                optionsBuilder.UseSqlServer("server=DESKTOP-J4PTH70;database=Yzl3447_CodeFirstDB;uid=sa;pwd=123;TrustServerCertificate=True;");
            }



            base.OnConfiguring(optionsBuilder);
        }


        //veritabanı oluşturulurken ilişkilendirmelerin detayları barındırılır.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Mapping (classlar arasındaki ilişilendirme)

            #region One To One Mapping
            //Bir AppUser'ın bir adet AppUserDetail olur.
            modelBuilder.Entity<AppUser>()//ID PK => identity
                .HasOne(x => x.UserDetail)
                .WithOne(x => x.User) //ID => FK
                .HasForeignKey<AppUserDetail>();

            //AppUser Seed Data
            modelBuilder.Entity<AppUser>()
                .HasData(AppUserSeedData.seedAppUserData);
            #endregion

            #region One To Many
           
            modelBuilder.Entity<Product>()
                .HasOne(x => x.Category)
                .WithMany(x => x.Products)
                .OnDelete(DeleteBehavior.Cascade)// Eğer bu tanımlı ise referans tablolar arasında veri silinir.
                .HasForeignKey(x => x.CategoryId);

            //Category Seed Data
            modelBuilder.Entity<Category>()
                .HasData(CategorySeedData.seedCategories);

            //Product Seed Data
            modelBuilder.Entity<Product>()
                .HasData(ProductSeedData.seedProductData);
            #endregion


            //Many To Many Mapping
            modelBuilder.Entity<StudentAndCourse>()
                .HasOne(x => x.Student)
                .WithMany(x => x.StudentCourses)
                .HasForeignKey(x => x.StudentId);

            modelBuilder.Entity<StudentAndCourse>()
               .HasOne(x => x.Course)
               .WithMany(x => x.StudentCourses)
               .HasForeignKey(x => x.CourseId);

            //CourseAndStudent tablosunda primary key özelleştirilmesi.
            modelBuilder.Entity<StudentAndCourse>()
                .HasKey(x => new { x.StudentId, x.CourseId });


            base.OnModelCreating(modelBuilder);
        }
    }
}
