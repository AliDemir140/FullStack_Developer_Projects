using OCP_Example.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Example.Concretes
{
    internal class Account : IDepartment
    {
        public Employee Create(IEmployee employee)
        {
            Employee employee1 = new Employee();
            employee1.Firstname = employee.Firstname;
            employee1.Lastname = employee.Lastname;
            employee1.Email = employee.Email;







            return employee1;
        }
    }
}
