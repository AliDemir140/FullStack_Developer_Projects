using FactoryMethodPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Concretes
{
    public class Mage : ICharacter
    {

      


        public void Attack()
        {
            Console.WriteLine("Mage saldırıyor...");
        }

        public void Defense()
        {
            Console.WriteLine("Mage savunuyor...");
        }
    }
}
