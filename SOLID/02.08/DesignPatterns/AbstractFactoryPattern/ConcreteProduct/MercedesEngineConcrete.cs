using AbstractFactoryPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ConcreteProduct
{
    internal class MercedesEngineConcrete : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Mercedes marka otomobilin motoru çalıştı...");
        }
    }
}
