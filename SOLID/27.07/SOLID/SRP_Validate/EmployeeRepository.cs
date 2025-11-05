using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Validate
{
    internal class EmployeeRepository
    {
        public static void CreateEmployee(Employee employee)
        {
            //SQL Server
            Console.WriteLine(employee.Firstname+" "+employee.Lastname+" veritabanına kaydedildi!");
        }
    }
}
