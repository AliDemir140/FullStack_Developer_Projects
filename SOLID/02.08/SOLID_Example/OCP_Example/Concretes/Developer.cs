using OCP_Example.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Example.Concretes
{
    internal class Developer : IEmployee
    {
        public Developer()
        {
            Department = new DeveloperAccount();
        }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }

        public IDepartment Department { get; set; }
    }
}
