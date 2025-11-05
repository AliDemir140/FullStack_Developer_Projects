using FactoryMethodPattern.Abstracts;
using FactoryMethodPattern.Concretes;
using FactoryMethodPattern.Creator.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Creator.Concretes
{
    public class MageCreator : BaseCharacterCreator
    {
        public override ICharacter CreateCharacter()
        {
           return new Mage();
        }
    }
}
