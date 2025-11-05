
///Soyut
//Abstraction => Soyutlama

//Not: Genellikle classlara öncülük eden/edecek olan base class'lar abstract olarak tnaımlanırlar.

///Soyut
//Interface=> Sözleşme /(Arayüz): Bir class'ın temelde hangi özelliklerdem meydana geldiğini abstract olarak tanımlanan classlar vasıtası ile oluşturuz aynı zamanda hangi yeteknekler (Metot) meydana geldiğini de interface'ler vasıtası ile tanımlanır.

//bir class birden fazla interface'den miras alabilir.

//Bir otomobil satış uygulamasında kullanılmak üzere otomobil oluşturabildiğimiz bir console app oluşturulacak.


using CA_Interface;



Mercedes mercedes1 = new Mercedes();
mercedes1.Marka = "Mercedes";
mercedes1.Model = "CLK";
mercedes1.Renk = "Beyaz";

Console.WriteLine(mercedes1.MaxHiz());

Audi audi = new Audi();
audi.Marka = "Audi";
audi.Model = "A6";
audi.Renk = "Siyah";
Console.WriteLine(audi.MaxHiz());

