
/*
 Single Responsibility

Her nesnenin ya da metodun sadece 1 sorumluluğu olmalıdır, sadece o işi yapmalı ve o işten sorumlu olmalıdır.

Böylece bir değişiklik yapılacağında, sadece bir nedene dayandırılır.

 */

using SRP_Validate;

class Program
{
    static void Main(string[] args)
    {
        //Karşılama Mesajı
        Message.Karsilama();
       Employee employee= EmployeeService.AddEmployee();

       bool validationResult= Validation.Validate(employee);

        if (!validationResult)
        {
            Console.Read();
            return;
        }
        EmployeeRepository.CreateEmployee(employee);    Console.Read();
    }
}