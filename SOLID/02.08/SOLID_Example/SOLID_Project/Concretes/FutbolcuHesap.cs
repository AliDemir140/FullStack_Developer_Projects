using SOLID_Project.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.Concretes
{
    public class FutbolcuHesap : IMevkii
    {
        public Futbolcu Olustur(IFutbolcu futbolcu)
        {
            Futbolcu futbolcu1 = new Futbolcu();
            futbolcu1.Ad = futbolcu.Ad;
            futbolcu1.Soyad= futbolcu.Soyad;    
            //futbolcu içerisinde mevkiileri temsil eden özellik ya da eylemler olması lazım.
            return futbolcu1;
        }
    }
}
