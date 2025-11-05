

namespace CA_Static
{
    internal class FizikKutuphanesi
    {

        //Eğer static olamyan bir class tanımlı ise içerisinde static üyeler barınabilir.
        //Eğer static olan bir class tanımlı ise içerisinde static olmayan üye BARINAMAZ!!!
        public static double YerCekimiKuvveti { get { return 9.81; } }//read only

        public int OrnekDeger { get; set; }
    }
}
