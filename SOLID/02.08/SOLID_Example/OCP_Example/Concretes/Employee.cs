using OCP_Example.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Example.Concretes
{
    public class Employee : IEmployee
    {
        public Employee()
        {
            //todo: buraya Idepartment interface'den türetilmiş bir nesnenin atanması gerekmektedir.
            Department = new Account();
        }
        public string Firstname { get ; set ; }
        public string Lastname { get ; set ; }
        public string Email { get ; set ; }

        public bool IsDeveloper { get; set; } //tamamlandı
        public bool IsMuhasebeci { get; set; }//tamamlandı
        public bool IsHumanResources { get; set; }

        public IDepartment Department { get; set; }

    }
}
