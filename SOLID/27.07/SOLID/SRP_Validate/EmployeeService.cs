using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Validate
{
    internal class EmployeeService
    {
        //bu metot kullanıcıdan çalışan bilgilerini alan metot.
        internal static Employee AddEmployee()
        {
            Employee employee = new Employee();
            Console.WriteLine("Çalışan Ad: ");
            employee.Firstname = Console.ReadLine();
           

            Console.WriteLine("Çalışan Soyad: ");
            employee.Lastname = Console.ReadLine();

            return employee;

        }
    }
}
