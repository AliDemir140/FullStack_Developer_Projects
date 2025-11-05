//Object Oriented Programming (Nesne Yönelimli Programlama)

//Nesnelerin özellikleri bulunur ve bu özellikleri bünyesinde barındırabilmesi C# programlama dilinde Class oluşturmamız gerekmektedir.




//CTRL+Shift+A=> bu tuş kombinasyonu class oluşturmamıza olanak sağlar.


//bir classı farklı bir class içerisinde çağırmak için "using" anahtar kelimesini kullanarak ilgili class'ın namespace'ni tanımlamak zorundayız.

using CA_Class;

#region Bilgisayar Classı
//Bilgisayar pc1 = new Bilgisayar();
//pc1.anakart = "MSI";
//pc1.islemci = "I7";
//pc1.grafikKart = "Nvidia";
//pc1.ramKapasite = "32";


//Bilgisayar pc2 = new Bilgisayar();
//pc2.anakart = "Asus";
//pc2.islemci = "I9";
//pc2.grafikKart = "Radeon";
//pc2.ramKapasite = "16";






//Console.WriteLine($"Islemci:{pc1.islemci} Anakart:{pc1.anakart} EkranKart:{pc1.grafikKart} RAMKapasitesi: {pc1.ramKapasite} ");

//Console.WriteLine($"Islemci:{pc2.islemci} Anakart:{pc2.anakart} EkranKart:{pc2.grafikKart} RAMKapasitesi: {pc2.ramKapasite} ");

//Console.Read(); 
#endregion

//Bir ayakkabı mağazası için "Ayakkabı" isminde nesne (class) oluşturun. 



//yukarıdaki bilgileri içeren bir class tanımlayın. Ardından 3 adet farklı ayakkabı oluşturarak bilgilerini console'da yazdırın. Bu bilgileri kullanıcıdan alın.
//Ayakkabı Marka: Adidas

#region Class ile birlikte yapılan işlem
//Ayakkabi[] ayakkabiKutusu = new Ayakkabi[3];







//void AyakkabiBilgisiAl()
//{
//    for (int i = 0; i < 3; i++)
//    {
//        Ayakkabi ayakkabi = new Ayakkabi();

//        Console.WriteLine("Ayakkabı Marka: ");
//        ayakkabi.marka = Console.ReadLine();
//        Console.WriteLine("Numara: ");
//        ayakkabi.numara = int.Parse(Console.ReadLine());
//        Console.WriteLine("Malzeme: ");
//        ayakkabi.malzeme = Console.ReadLine();
//        Console.WriteLine("Bağcıklı mı?: ");
//        ayakkabi.bagcikli = bool.Parse(Console.ReadLine());
//        Console.WriteLine("Fiyat: ");
//        ayakkabi.fiyat = decimal.Parse(Console.ReadLine());

//        ayakkabiKutusu[i] = ayakkabi;
//    }
//}

//void AyakkabiBilgileriniYazdir()
//{
//    foreach (Ayakkabi ayakkabi in ayakkabiKutusu)
//    {
//        Console.WriteLine("Ayakkabı  Bilgileri:");
//        Console.WriteLine($"Marka: {ayakkabi.marka} numara: {ayakkabi.numara} malzeme: {ayakkabi.malzeme} bagcıklı: {ayakkabi.bagcikli} Fiyat: {ayakkabi.fiyat}");
//    }
//}

//AyakkabiBilgisiAl();
//AyakkabiBilgileriniYazdir();

//for (int i = 0;i < ayakkabiKutusu.Length; i++)
//{
//    Console.WriteLine(ayakkabiKutusu[i].marka);
//}

#endregion


AyakkabiIslem ayakkabiIslem = new AyakkabiIslem();

Ayakkabi[] ayakkabilar = ayakkabiIslem.AyakkabiBilgisiAl();
ayakkabiIslem.AyakkabiBilgileriniYazdir(ayakkabilar);


#region Yapısal
//Ayakkabi ayakkabi1=new Ayakkabi();

//Console.WriteLine("Ayakkabı Marka: ");
//ayakkabi1.marka = Console.ReadLine();
//Console.WriteLine("Numara: ");
//ayakkabi1.numara = int.Parse(Console.ReadLine());
//Console.WriteLine("Malzeme: ");
//ayakkabi1.malzeme = Console.ReadLine();
//Console.WriteLine("Bağcıklı mı?: ");
//ayakkabi1.bagcikli=bool.Parse(Console.ReadLine());
//Console.WriteLine("Fiyat: ");
//ayakkabi1.fiyat = decimal.Parse(Console.ReadLine());


//Ayakkabi ayakkabi2 = new Ayakkabi();

//Console.WriteLine("Ayakkabı Marka: ");
//ayakkabi2.marka = Console.ReadLine();
//Console.WriteLine("Numara: ");
//ayakkabi2.numara = int.Parse(Console.ReadLine());
//Console.WriteLine("Malzeme: ");
//ayakkabi2.malzeme = Console.ReadLine();
//Console.WriteLine("Bağcıklı mı?: ");
//ayakkabi2.bagcikli = bool.Parse(Console.ReadLine());
//Console.WriteLine("Fiyat: ");
//ayakkabi2.fiyat = decimal.Parse(Console.ReadLine());


//Ayakkabi ayakkabi3 = new Ayakkabi();

//Console.WriteLine("Ayakkabı Marka: ");
//ayakkabi3.marka = Console.ReadLine();
//Console.WriteLine("Numara: ");
//ayakkabi3.numara = int.Parse(Console.ReadLine());
//Console.WriteLine("Malzeme: ");
//ayakkabi3.malzeme = Console.ReadLine();
//Console.WriteLine("Bağcıklı mı?: ");
//ayakkabi3.bagcikli = bool.Parse(Console.ReadLine());
//Console.WriteLine("Fiyat: ");
//ayakkabi3.fiyat = decimal.Parse(Console.ReadLine());


//Console.WriteLine("Ayakkabı 1 Bilgileri:");
//Console.WriteLine($"Marka: {ayakkabi1.marka} numara: {ayakkabi1.numara} malzeme: {ayakkabi1.malzeme} bagcıklı: {ayakkabi1.bagcikli} Fiyat: {ayakkabi1.fiyat}");

//Console.WriteLine("Ayakkabı 2 Bilgileri:");
//Console.WriteLine($"Marka: {ayakkabi2.marka} numara: {ayakkabi2.numara} malzeme: {ayakkabi2.malzeme} bagcıklı: {ayakkabi2.bagcikli} Fiyat: {ayakkabi2.fiyat}");

//Console.WriteLine("Ayakkabı 3 Bilgileri:");
//Console.WriteLine($"Marka: {ayakkabi3.marka} numara: {ayakkabi3.numara} malzeme: {ayakkabi3.malzeme} bagcıklı: {ayakkabi3.bagcikli} Fiyat: {ayakkabi3.fiyat}"); 
#endregion

Console.Read();