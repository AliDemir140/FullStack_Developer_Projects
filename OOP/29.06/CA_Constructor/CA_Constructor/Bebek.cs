namespace CA_Constructor
{
    internal class Bebek
    {
     
        //Constructor: Yapıcı metotlaar class adı ile aynı ada sahip olmalıdırlar. Geriye değer döndürmezler, Aynı zamanda void anahtar kelimesi de almazlar.

        //Constructor'ların overload (aynı isme sahip metodun farklı kullanımları)'ları mevcuttur. Istersek birden fazla constructor oluşturabilir.



        /// <summary>
        /// eğer herhangi bir parametre iletilmezse doğum tarihi otomatik alınır.
        /// </summary>
        public Bebek()
        {
            DogumTarihi=DateTime.Now;
        }


        /// <summary>
        /// parametre olarak Anne Ad göndeirlirse class otomatik olarak bu değeri AnneAd'a taşır.
        /// </summary>
        /// <param name="anneAd"></param>
        public Bebek(string anneAd)
        {
            DogumTarihi = DateTime.Now;
            AnneAd = anneAd;
        }

        public Bebek(string anneAd, string babaAd)
        {
            DogumTarihi = DateTime.Now;
            AnneAd = anneAd;
            BabaAd = babaAd;
        }

        public Bebek(string anneAd, string babaAd, bool cinsiyet)
        {
            DogumTarihi = DateTime.Now;
            AnneAd = anneAd;
            BabaAd = babaAd;
            Cinsiyet = cinsiyet;
        }



        public string AnneAd { get; set; }
        public string BabaAd { get; set; }
        public bool Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }

     
    }
}
