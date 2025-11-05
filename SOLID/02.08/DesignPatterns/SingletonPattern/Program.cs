//Singleton Pattern: bir instance alımı esnasında önce nesnenin daha önce instace'ı alınmış mı? kontrol edilir. eğer instance alınmamış ise bir defaya mahsus instance alınır ve her istekte bulunan kişiye o instance verilir.

using SingletonPattern.Models.Context;


ProjectContext context = new ProjectContext();


foreach (var item in context.ProductData.Products)
{
    Console.WriteLine(item.ID+" "+item.ProductName);
}


foreach (var item in context.ProductData.Products)
{
    Console.WriteLine(item.ID + " " + item.ProductName);
}