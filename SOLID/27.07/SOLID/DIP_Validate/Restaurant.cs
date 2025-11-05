using DIP_Validate.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Validate
{
    internal class Restaurant
    {
        private List<IProduct> _product;

        public Restaurant(List<IProduct> product)
        {
            _product = product;
        }

        public string Tarifler()
        {
            string tarifler = "";
            foreach(IProduct p in _product)
            {
                tarifler += p.Tarif() + "\n";
            }
            return tarifler;
        }

    }
}
