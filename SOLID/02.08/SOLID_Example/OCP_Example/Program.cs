
using OCP_Example.Abstracts;
using OCP_Example.Concretes;

Employee employee = new Employee();

//
List<IEmployee> employees = new List<IEmployee>()
{
    new Employee{Firstname="John",Lastname="Doe"}, //???
    new Muhasebe{Firstname="Nancy",Lastname="Davolio"},
    new Developer{Firstname="Fatih",Lastname="günalp"},
    new HumanResources{Firstname="Arda",Lastname="Berktaş"}
};


List<Employee> employees1 = new List<Employee>();


//İşe alımı temsil eden döngü: yani employees içerisinde bulunan bütün adaylara ait hesap oluşturarak ardından employee1 koleksiyonu içerisine dahil eder.
foreach (IEmployee emp in employees)
{
    employees1.Add(emp.Department.Create(emp));
}


//Çalışan bilgilerinin listelenmesi.
foreach (Employee emp in employees1)
{
    Console.WriteLine(emp.Firstname+" "+emp.Lastname+" Muhasebeci: "+emp.IsMuhasebeci+" Geliştirici: "+emp.IsDeveloper+" İnsan Kaynakları: "+emp.IsHumanResources);
}