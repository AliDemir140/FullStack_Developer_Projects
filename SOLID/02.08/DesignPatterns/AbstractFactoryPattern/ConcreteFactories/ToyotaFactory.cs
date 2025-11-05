using AbstractFactoryPattern.Abstracts;
using AbstractFactoryPattern.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ConcreteFactories
{
    internal class ToyotaFactory : IAbstractCarFactory
    {
        public IEngine CreateEngine()
        {
            return new ToyotaEngineConcrete();
        }

        public ITire CreateTire()
        {
            return new ToyotaTireConcrete();
        }
    }
}
