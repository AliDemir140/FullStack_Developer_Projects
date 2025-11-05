//Otomobil isminde bir nesne (class) oluşturun. Bu nesne aşağıdaki alanları (field) barındırsın.

//Encapsulation


using CA_Encapsulation;

Otomobil otomobil = new Otomobil();

//otomobil.marka = "BMW";
//if (otomobil.marka != "Mercedes")
//{
//    otomobil.marka = "tanımsız";
//}
otomobil.Marka = "bmw";
otomobil.model = "AMG";
otomobil.motorHacim = 2.0;
otomobil.renk = "beyaz";
otomobil.sanziman = "otomatik";

Console.WriteLine(otomobil.Marka);


