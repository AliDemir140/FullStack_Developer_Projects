namespace CA_Inheritance
{
    public class Bilgisayar:BaseClass
    {
        //Bilgisayar'ın ...'sı olur.
        //Islemci
        public Islemci Islemci { get; set; }
        //Anakart
        public Anakart Anakart { get; set; }
        //Ram
        public Ram Ram { get; set; }
        //EkranKart
        public EkranKart EkranKart { get; set; }
        //Fiyat
        public decimal Fiyat { get; set; }

       
    }
}
