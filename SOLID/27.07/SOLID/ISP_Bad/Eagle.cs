using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Bad
{
    internal class Eagle : IBird
    {
        public string Fly()
        {
            return "Kartal uçuyor";
        }

        public string Walk()
        {
            return "Kartal yürüyor";
        }
    }
}
