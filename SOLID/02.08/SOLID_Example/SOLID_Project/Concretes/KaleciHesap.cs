using SOLID_Project.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.Concretes
{
    internal class KaleciHesap : IMevkii
    {
        public Futbolcu Olustur(IFutbolcu futbolcu)
        {
            Futbolcu futbolcu1 = new Futbolcu();
            futbolcu1.Ad = futbolcu.Ad;
            futbolcu1.Soyad = futbolcu.Soyad;
            futbolcu1.IsKaleci= true;
            return futbolcu1;
        }
    }
}
