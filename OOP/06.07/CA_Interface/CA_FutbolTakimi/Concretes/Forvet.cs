using CA_FutbolTakimi.Abstracts;

namespace CA_FutbolTakimi.Concretes
{
    internal class Forvet : Futbolcu,IForvet
    {
        public override int SutGuc { get ; set ; }
        public override int KosmaGuc { get ; set ; }

        public string CalimAt()
        {
            throw new NotImplementedException();
        }

        public string SutCek()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Forvet Oyuncusu: {ID} {Ad} {Soyad} {Forma}";
        }
    }
}
