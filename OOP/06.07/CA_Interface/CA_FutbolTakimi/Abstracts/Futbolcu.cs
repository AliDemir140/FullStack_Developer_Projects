namespace CA_FutbolTakimi.Abstracts
{
    internal abstract class Futbolcu
    {
        //Kişisel özellikler
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Forma { get; set; }

        //Futbol özellikleri
        public abstract int SutGuc { get; set; }
        public abstract int KosmaGuc { get; set; }
    }
}
