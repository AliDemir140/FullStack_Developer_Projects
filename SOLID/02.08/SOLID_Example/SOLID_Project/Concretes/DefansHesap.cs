using SOLID_Project.Abstracts;

namespace SOLID_Project.Concretes
{
    internal class DefansHesap : IMevkii
    {
        public Futbolcu Olustur(IFutbolcu futbolcu)
        {
            Futbolcu futbolcu1 = new Futbolcu();
            futbolcu1.Ad = futbolcu.Ad;
            futbolcu1.Soyad = futbolcu.Soyad;
            futbolcu1.IsDefans = true;
            return futbolcu1;
        }
    }
}