using DIP_Validate.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Validate.Concretes
{
    internal class PizzaMenu : IProduct
    {
        public string Tarif()
        {
            return "ince hamur ile pişirilen pizaalar";
        }
    }
}
