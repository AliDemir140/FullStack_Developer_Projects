using CA_FutbolTakimi.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_FutbolTakimi.Concretes
{
    internal class OrtaSaha : Futbolcu,IOrtaSaha
    {
        public override int SutGuc { get ; set ; }
        public override int KosmaGuc { get ; set ; }

        public string OyunKur()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Orta saha Oyuncusu: {ID} {Ad} {Soyad} {Forma}";
        }
    }
}
