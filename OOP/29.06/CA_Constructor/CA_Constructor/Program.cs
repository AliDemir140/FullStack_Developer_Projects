//4-Abstraction => Soyutlama

//Constructor (Yapıcı Metot) 
/*
 Yapıcı metot olarak adlandırılan ve bir nesnenin örneği alımı esnasında ilk tetiklenen metotdur. Her class'ın arkaplanda (gömülü) bir constructor metodu bulunur. Ancak bu metot gizlidir. İstersek biz bu gömülü olan metodunu ezerek farklı bir davranış haline getirebiliriz.
 */



//Bir hastane'nin yeni doğan unitesine ait bir uygulama yazılacak. Bu uygulama dünyaya yeni gelen bebeklerin kayıtlarını tutmalı. Bu kayıt içerisinde aşağıdaki bilgiler yeralacak. 

//Bebek 1
using CA_Constructor;

Bebek bebek1=new Bebek();
bebek1.AnneAd = "Fatma";
bebek1.BabaAd = "Murat";
bebek1.Cinsiyet = false;
//bebek1.DogumTarihi=DateTime.Now;

Bebek bebek2 = new Bebek("Ayşe");
bebek2.BabaAd = "Ali";
bebek2.Cinsiyet = true;
//bebek2.DogumTarihi = DateTime.Now;

Bebek bebek3 = new Bebek("Zeynep", "Hasan", false);
Console.WriteLine(bebek1.DogumTarihi);
Console.WriteLine(bebek2.DogumTarihi);


//Instance
Bebek bebek4 = new Bebek();
bebek4.AnneAd = "";
//constructor
Bebek bebek5 = new Bebek("Merve");
//Object initiliazier (Nesne'nin örneğinin alımı esnasında)

Bebek bebek6 = new Bebek("Ayşe")
{
    AnneAd = "Merve",
    BabaAd = "Gökhan",
    Cinsiyet = false,
    DogumTarihi = DateTime.Now
};


Console.WriteLine("Anne Ad: ");
string gelenAnneAd = Console.ReadLine();
Bebek bebek7 = new Bebek(gelenAnneAd);








