using CA_CodeFirst.Models.Entities;

namespace CA_CodeFirst.Models.Seeds
{
    public class AppUserSeedData
    {
       public static List<AppUser> seedAppUserData = new List<AppUser>
            {
                new AppUser
                {
                    ID=1,
                    Email="andrew@northwind.com",
                    Password="1234"
                },
                new AppUser
                {
                    ID=2,
                    Email="nancy@northwind.com",
                    Password="1234"
                },
                new AppUser
                {
                    ID=3,
                    Email="janet@northwind.com",
                    Password="1234"
                },

            };
    }
}
