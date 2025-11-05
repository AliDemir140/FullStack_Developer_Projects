using SOLID_Project.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.Concretes
{
    public class Futbolcu : IFutbolcu
    {
        public string Ad { get ; set ; }
        public string Soyad { get ; set ; }
        public string FormaNo { get ; set ; }

        public bool IsKaleci { get; set; }
        public bool IsDefans { get; set; }

        public bool IsOrtasaha { get; set; }

        public bool IsForvet { get; set; }
        public IMevkii Mevkii { get ; set ; }
    }
}
