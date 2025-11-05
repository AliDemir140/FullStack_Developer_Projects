using AbstractFactoryPattern.Abstracts;
using AbstractFactoryPattern.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ConcreteFactories
{
    public class MercedesFactory : IAbstractCarFactory
    {
        //todo: bu class ortak bir factory'den miras alacak.
        public IEngine CreateEngine()
        {
            return new MercedesEngineConcrete();
        }

        public ITire CreateTire()
        {
            return new MercedesTireConcrete();
        }
    }
}
