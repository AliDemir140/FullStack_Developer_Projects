using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.Abstracts
{
    public interface IFutbolcu
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string FormaNo { get; set; }

        //Mevkii'de futbolcu tanımlamak için
        public IMevkii Mevkii { get; set; }
    }
}
