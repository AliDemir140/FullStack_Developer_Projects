using AbstractFactoryPattern.Abstracts;
using AbstractFactoryPattern.ConcreteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AssemblyLine
{
    internal class CarAssemblyLine//Abstract factory
    {

        private IAbstractCarFactory _abstractCarFactory;

        public CarAssemblyLine(IAbstractCarFactory abstractCarFactory)
        {
            _abstractCarFactory = abstractCarFactory;
        }


        public void AssemblyCar()
        {
            IEngine engine = _abstractCarFactory.CreateEngine();
            ITire tire = _abstractCarFactory.CreateTire();

            Console.WriteLine("Otomobil montajı başlıyor....");
            engine.Start();
            tire.Inflate();
            Console.WriteLine("Otomobil montajı tamamlandı....");

        }

    }
}
