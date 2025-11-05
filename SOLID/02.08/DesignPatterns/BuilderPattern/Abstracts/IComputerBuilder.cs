using BuilderPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Abstracts
{
    internal interface IComputerBuilder
    {
        //bilgisayar parçalarını inşası ile ilgilenen interface.
        //İşlemci
        void BuildIslemci();
        //Ram
        void BuildRam();
        //EkranKart
        void BuildEkranKarti();

        Computer GetComputer();
    }
}
