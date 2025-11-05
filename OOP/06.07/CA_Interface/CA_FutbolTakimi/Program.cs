//Kaleci
//Defans
//OrtaSaha
//Forvet

//Yukarıdaki tanımlanacak nesneleri Abstract ve Interface kullanarak yapılandırın. Her birin futbolcu bulunsun.

//Console uygulaması için aşağıda işlemlerin tanımlaması gerekmektedir.

//Console çalıştığında takım oyuncuları mevkiilerine göre listelenebilmeli. Her instance ile birlikte her mevkiide bir adet futbolcu olması gerekmektedir.
//Örn: 
/*
    1-Kaleciler (Liste)
    2-Defanslar (Liste)
    3-Ortasahalar (Liste)
    4-Forvetler  (Liste)
    secim: 2

Yukarıdaki işlem OOP prensiplerine uygun olarak oluşturulacak. 

 */

using CA_FutbolTakimi.Concretes;
ConsoleMenu consoleMenu = new ConsoleMenu();

//Örnek futbolcular liste içerisine eklenmesi
string result = consoleMenu.CreateSampleFutbolcular();

Console.WriteLine(result);

//
while (true)
{
    //todo: aşağıdaki işlem bir defaya mahsus getiriyior. ikinci döngüde boş getiririyor.
    string selected = consoleMenu.GetConsoleMenu();

    consoleMenu.GetFutbolcular(selected);

  
}
