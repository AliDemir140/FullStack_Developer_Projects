using DIP_Validate.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Validate.Concretes
{
    internal class TavukMenu : IProduct
    {
        public string Tarif()
        {
            return "Gezen tavuklardan taze olarak pişirilir.";
        }
    }
}
