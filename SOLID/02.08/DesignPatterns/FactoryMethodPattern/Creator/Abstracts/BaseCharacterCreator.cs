using FactoryMethodPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Creator.Abstracts
{
    public abstract class BaseCharacterCreator
    {
        public abstract ICharacter CreateCharacter();
    }
}
