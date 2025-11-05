/*
    Nesne Yönelimli Programlama Prensipleri

1-Encapsulation => Kapsulleme
    //Get: verinin getirilmesini (okunması)
    //Set: verinin tanımlanması (atanması)
2-Polymorphism
3-Inheritance
4-Abstraction
 */

using CA_Encapsulation;

Product product = new Product();
product.Marka = "Adias";
product.Renk = "beyaz";
product.Kategori = "tshirt";
product.Beden = "domates"; // bedenler sabit olmalı. Yani içerisine alacağı değerler S,M,L,XL olmalı. Harici değer gelirse beden null olarak kalmalı.

product.Fiyat = 100;//set
//product.KdvDahilFiyat = 500;//bu alan dışarıdan değer almamalı!!!!


//if (product.Beden != null)
//{
//    Console.WriteLine(product.Beden);
//}
//else
//{
//    Console.WriteLine("Beden tanımsız!");
//}
Console.WriteLine(product.Beden);
Console.WriteLine(product.Fiyat);
Console.WriteLine(product.KdvDahilFiyat);//get



Console.Read();

