using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Class
{
    internal class AyakkabiIslem
    {
       public Ayakkabi[] AyakkabiBilgisiAl()
        {
            Ayakkabi[] ayakkabiKutusu = new Ayakkabi[3];
            for (int i = 0; i < 3; i++)
            {
                Ayakkabi ayakkabi = new Ayakkabi();

                Console.WriteLine("Ayakkabı Marka: ");
                ayakkabi.marka = Console.ReadLine();
                Console.WriteLine("Numara: ");
                ayakkabi.numara = int.Parse(Console.ReadLine());
                Console.WriteLine("Malzeme: ");
                ayakkabi.malzeme = Console.ReadLine();
                Console.WriteLine("Bağcıklı mı?: ");
                ayakkabi.bagcikli = bool.Parse(Console.ReadLine());
                Console.WriteLine("Fiyat: ");
                ayakkabi.fiyat = decimal.Parse(Console.ReadLine());

                ayakkabiKutusu[i] = ayakkabi;
            }
            return ayakkabiKutusu;

        }

       public void AyakkabiBilgileriniYazdir(Ayakkabi[] ayakkabilar)
        {
            foreach (Ayakkabi ayakkabi in ayakkabilar)
            {
                Console.WriteLine("Ayakkabı  Bilgileri:");
                Console.WriteLine($"Marka: {ayakkabi.marka} numara: {ayakkabi.numara} malzeme: {ayakkabi.malzeme} bagcıklı: {ayakkabi.bagcikli} Fiyat: {ayakkabi.fiyat}");
            }
        }
    }
}
