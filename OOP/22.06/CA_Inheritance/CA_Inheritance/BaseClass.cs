using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Inheritance
{
    public class BaseClass//bu class özelliklerini diğer class'lara kalıtım olarak verecek.
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public decimal Fiyat { get; set; }
    }
}
