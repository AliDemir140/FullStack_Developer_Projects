using SRP_Bad;

class Program
{
    public static void Main(string[] args)
    {
        while (true) {
            //karşılama
            Console.WriteLine("Hoşgeldiniz!!!");




            //Çalışan oluşturmak için alınan instance

            Employee employee = new Employee();

            //Çalışan bilgilerinin alınması
            Console.WriteLine("Çalışan Ad: ");
            employee.Firstname = Console.ReadLine();
            //Özelliklerin doğrulanması
            if (string.IsNullOrEmpty(employee.Firstname))
            {
                Console.WriteLine("çalışan adı boş geçilemez!");
                return;
            }

            Console.WriteLine("Çalışan Soyad: ");
            employee.Lastname = Console.ReadLine();

            if (string.IsNullOrEmpty(employee.Lastname))
            {
                Console.WriteLine("çalışan soyadı boş geçilemez!");
                return;
            }

            employee.ID = Employee.employees.Count + 1;

            Employee.employees.Add(employee);
            Console.WriteLine("Çalışan oluşturuldu!");
        }


    }
}