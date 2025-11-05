using AbstractFactoryPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ConcreteProduct
{
    internal class ToyotaEngineConcrete : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Toyota marka otomobilin motoru çalıştı...");
        }
    }
}
