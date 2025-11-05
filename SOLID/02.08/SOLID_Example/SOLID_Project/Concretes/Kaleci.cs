using SOLID_Project.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.Concretes
{
    internal class Kaleci : IFutbolcu
    {
        public Kaleci()
        {
            Mevkii = new KaleciHesap();
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string FormaNo { get; set; }
        public IMevkii Mevkii { get; set; }
    }
}
