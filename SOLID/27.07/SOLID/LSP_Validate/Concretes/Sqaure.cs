using LSP_Validate.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Validate.Concretes
{
    internal class Sqaure : BaseShape
    {
        public override double CalculateArea()
        {
            return Edge * Edge;
        }
    }
}
