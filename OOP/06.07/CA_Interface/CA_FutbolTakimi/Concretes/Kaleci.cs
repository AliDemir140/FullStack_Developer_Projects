
using CA_FutbolTakimi.Abstracts;

namespace CA_FutbolTakimi.Concretes
{
    internal class Kaleci : Futbolcu,IKaleci
    {
       
        public override int SutGuc { get ; set ; }
        public override int KosmaGuc { get ; set ; }

        public string Degaj()
        {
            return $"{Ad} degajı {SutGuc} kadar gerçekleştirdi.";
        }

        public string Kurtar()
        {
            return $"{Ad} topu kurtarmak için hamle yaptı";
        }

        public override string ToString()
        {
            return $"Kaleci Oyuncusu: {ID} {Ad} {Soyad} {Forma}";
        }
    }
}
