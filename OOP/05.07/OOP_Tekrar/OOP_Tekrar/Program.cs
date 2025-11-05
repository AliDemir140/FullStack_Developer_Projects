/*
 ++Static => Durağan, sabit
++Constructor => yapıcı metot.
++Polymorphism => çok biçimlilik.
++Inheritance=> Kalıtım
++Encapsulation => bir class içerisinde tanımlı olan field'a yapılan istekleri kontrol altına alma işlemi. (Get, Set)
++Class => neşenin özelliklerinin barındırıldığı alan.
 */


//Bilgisayar


using OOP_Tekrar;

Anakart anakart = new Anakart();
anakart.Marka = "ASD";
anakart.Fiyat = 10000;
anakart.ID= 1;
//anakart.CreatedDate = DateTime.Now;
decimal kampanyaliAnakartFiyat=anakart.Kampanya();

Ram ram = new Ram();
ram.ID = 1;
ram.Fiyat = 5000;
ram.Marka = "Kingston";
//ram.CreatedDate = DateTime.Now;
decimal kampanyaliRamFiyat=ram.Kampanya();

Console.WriteLine(anakart.Fiyat+" "+kampanyaliAnakartFiyat);

Console.WriteLine(ram.Fiyat+" "+kampanyaliRamFiyat);


//PcBilesenData pcBilesenData=new PcBilesenData();
//pcBilesenData.BilesenListesi.Add(anakart);
//pcBilesenData.BilesenListesi.Add(ram);
PcBilesenData.BilesenListesi.Add(anakart);
PcBilesenData.BilesenListesi.Add(ram);




//collection (array)
//Generic collection


Console.Read();