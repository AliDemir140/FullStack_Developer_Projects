using CA_FutbolTakimi.Abstracts;

namespace CA_FutbolTakimi.Concretes
{
    internal class Defans : Futbolcu,IDefans
    {
        public override int SutGuc { get ; set ; }
        public override int KosmaGuc { get ; set ; }

        public string PresYap()
        {
            throw new NotImplementedException();
        }

        public string TopKap()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Defans Oyuncusu: {ID} {Ad} {Soyad} {Forma}";
        }
    }
}
