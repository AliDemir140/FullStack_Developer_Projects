using CA_FutbolTakimi.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_FutbolTakimi.Concretes
{
    internal class ConsoleMenu : IConsoleMenu
    {
        static List<Futbolcu> Futbolcular=new List<Futbolcu>();//private
        public string CreateSampleFutbolcular()
        {
            //Kaleci
            Kaleci kaleci = new Kaleci { ID = 1, Ad = "Altay", Soyad = "Bayındır", Forma = "1" };
            Futbolcular.Add(kaleci);
            //Defans
            Defans defans = new Defans { ID = 2, Ad = "Antonio", Soyad = "Rüdiger", Forma = "2" };
            Futbolcular.Add(defans);
            //OrtaSaha
            OrtaSaha ortaSaha = new OrtaSaha { ID = 4, Ad = "Arda", Soyad = "Güler", Forma = "15" };
            Futbolcular.Add(ortaSaha);
            //Forvet
            Forvet forvet = new Forvet { ID = 5, Ad = "Kylian", Soyad = "Mbappe", Forma = "9" };
            Futbolcular.Add(forvet);
            return "Varsayılan örnek futbolcular oluşturuldu";
        }

        public string GetConsoleMenu()
        {
            string[] menuItems = { "Kaleciler", "Defans", "OrtaSaha", "Forvet" };
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine($"{i + 1}.{menuItems[i]}");
            }
            Console.Write("seçim: ");
            string selectedMenu = Console.ReadLine();
            return selectedMenu;
        }

        public void GetFutbolcular(string selectedMenu)//1
        {
            switch (selectedMenu)
            {

                case "1":
                    foreach (Futbolcu f in Futbolcular)
                    {
                        if(f is Kaleci)
                        {
                            Kaleci kaleci = (Kaleci)f;
                            Console.WriteLine(kaleci);
                        }
                        
                    }
                    break;


                    case "2":
                    foreach (Futbolcu f in Futbolcular)
                    {
                        if (f is Defans)
                        {
                            Defans defans = (Defans)f;
                            Console.WriteLine(defans);
                        }
                    }
                    break;

                    case "3":

                    foreach (Futbolcu f in Futbolcular)
                    {
                        if (f is OrtaSaha)
                        {
                            OrtaSaha ortaSaha = (OrtaSaha)f;
                            Console.WriteLine(ortaSaha);
                        }
                    }
                    break;

                    case "4":
                    foreach (Futbolcu f in Futbolcular)
                    {
                        if (f is Forvet)
                        {
                            Forvet forvet = (Forvet)f;
                            Console.WriteLine(forvet);
                        }
                    }
                    break;


                default:
                    break;
            }
        }
    }
}
