using FactoryMethodPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Concretes
{
    public class Warrior : ICharacter
    {
        public void Attack()
        {
            Console.WriteLine("Warrior saldırıyor...");
        }

        public void Defense()
        {
            Console.WriteLine("Warrior savunuyor...");
        }
    }
}
