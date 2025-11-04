//burası yorum satırı

/*
 burası yorum alanı.


 */


//class: bir class'ın bir ya da birden fazla özellikleri/eylemleri bulunabilir. bu özellik ve eylemlere . ile ulaşabilmekteyiz.


//KURALLAR
//1-C# programlama dilinde satır sonları ; ile sonlandırılmalı.
//2-Metinsel değerler " " arasında tanımlanmalıdır.
//3-C# programlama dili case sensity (büyük küçük harf duyarlıdır)'dir.
//4-C# programlama dilinde classlar Pascal Case olarak tanımlıdır.



//WriteLine() => console penceresinde imlecin bağlı bulunduğu satıra belirtilen değeri yazar ardından imleci bir alt satıra kaydrırır.
//Write()=> console penceresinde imlecin ait olduğu satıra değeri yazar.

//Read()=> sayfanın kapanmaması için console penceresinin devamlı okunmasını sağlayan eylemdir.

//ReadLine()=>imlecin bağlı bulunduğu satırın okunmasını sağlar. (Enter'a basıldığında)

//ReadKey()=>imlecin bağlı bulunduğu satırı herhangi bir tuşa basarak okunmasını sağlar. (herhangi bir karakter kullanıldığında)

//seçili olan kodları yorum alanına almak için kullancağımız tuş kombinasyonu CTRL+K+C yorum satırını geri almak için CTRL+K+U tuş kombinasyonunu kullanabiliriz.

#region WriteLine()
//Console.WriteLine("Merhaba Dünya!");
//Console.WriteLine("Hello World!");
//Console.WriteLine("Hola Mundop"); 
#endregion

#region Write()
//Console.Write("Merhaba Dünya");
//Console.Write("Hello World");
//Console.Write("Hola Mundo"); 
#endregion

Console.Write("Adınız: ");
Console.ReadLine();
Console.Write("Soyadınız: ");
Console.ReadLine();
Console.Write("Adresiniz: ");
Console.ReadLine();

