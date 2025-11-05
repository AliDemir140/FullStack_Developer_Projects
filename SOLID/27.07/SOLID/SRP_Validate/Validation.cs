using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Validate
{
    internal class Validation
    {
        //çalışan bilgilerinin boş olup olmadığını kontrol eden metot.

        internal static bool Validate(Employee employee)
        {
            if (string.IsNullOrEmpty(employee.Firstname))
            {
                Message.ErrorMessage("Ad");
                return false;
            }
            if (string.IsNullOrEmpty(employee.Lastname))
            {
                Message.ErrorMessage("Soyad");
                return false;
            }
            return true;
        }
    }
}
