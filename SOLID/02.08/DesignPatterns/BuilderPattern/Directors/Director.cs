using BuilderPattern.Abstracts;
using BuilderPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Directors
{
    internal class Director
    {
        public void Construct(IComputerBuilder builder)
        {
            builder.BuildEkranKarti();
            builder.BuildRam();
            builder.BuildIslemci();
        }
    }
}
