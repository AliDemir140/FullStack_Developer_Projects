using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Bad
{
    internal class Hawk : IBird
    {
        public string Fly()
        {
            return "Şahin uçuyor";
        }

        public string Walk()
        {
            return "Şahin yürüyor";
        }
    }
}
