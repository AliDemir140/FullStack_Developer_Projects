using BuilderPattern.Abstracts;
using BuilderPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Concretes
{
    internal class OfficeComputer : IComputerBuilder
    {
        Computer computer = new Computer();
        public void BuildEkranKarti()
        {
            computer.EkranKarti = "Nvidia RTX3090";
        }

        public void BuildIslemci()
        {
            computer.Islemci = "I7";
        }

        public void BuildRam()
        {
            computer.Ram = "32 GB";
        }

        public Computer GetComputer()
        {
            return computer;
        }
    }
}
