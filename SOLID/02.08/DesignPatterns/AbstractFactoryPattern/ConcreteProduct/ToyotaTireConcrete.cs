using AbstractFactoryPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ConcreteProduct
{
    internal class ToyotaTireConcrete : ITire
    {
        public void Inflate()
        {
            Console.WriteLine("Toyota marka otomobilin lastikleri şişirildi...");
        }
    }
}
