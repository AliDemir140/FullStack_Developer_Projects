using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Validate
{
    internal class LatteCoffee : Coffee
    {
        public override decimal GetTotalPrice(int amount)
        {
            return amount * 120;
        }
    }
}
