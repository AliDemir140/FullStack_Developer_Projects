using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Abstraction
{
    internal class Gitar:Enstruman
    {
        public bool Perdeli { get; set; }

        public override string Cal()
        {
            return Marka + " markasına ait gitar çalınıyor...";
        }

    }
}
