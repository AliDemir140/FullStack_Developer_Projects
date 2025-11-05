using OCP_Example.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Example.Concretes
{
    internal class Muhasebe : IEmployee
    {
        public Muhasebe()
        {
            Department = new MuhasebeAccount();
        }
        public string Firstname { get ; set ; }
        public string Lastname { get ; set ; }
        public string Email { get ; set ; }

        public IDepartment Department { get; set; }

        //Aylık KDV
        //Yıllık Gelir
        //Stopaj
    }
}
