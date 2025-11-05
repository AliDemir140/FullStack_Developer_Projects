using ISP_Validate.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Validate.Concretes
{
    internal class Chicken : IFlightless
    {
        public string Walk()
        {
            return "Tavuk yürüyor";
        }
    }
}
