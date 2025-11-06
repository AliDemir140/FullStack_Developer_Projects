namespace CA_CodeFirst.Models.Entities
{
    public class AppUser//Bu class tablo haline gelecek olan class'dır.
    {
        public int ID { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        //Bir AppUser'ın bir adet AppUserDetail
        public AppUserDetail UserDetail { get; set; }
    }
}
