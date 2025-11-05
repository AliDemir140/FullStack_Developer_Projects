using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Models
{
    internal class Computer
    {
        public string Islemci { get; set; }
        public string EkranKarti { get; set; }
        public string Ram { get; set; }

        public override string ToString()
        {
            return Islemci+" "+EkranKarti+" "+Ram;
        }
    }
}
