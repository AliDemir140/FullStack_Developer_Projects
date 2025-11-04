//Geriye Değer Döndüren=> Parametre almayan


//console'da kullanıcdan 2 adet sayı alın. Bu sayıların toplamını console'da yazdırın.

void Topla()
{
    Console.WriteLine("sayı bir: ");
    int sayiBir = int.Parse(Console.ReadLine());

    Console.WriteLine("sayı iki: ");
    int sayiIki = int.Parse(Console.ReadLine());

    int toplam = sayiBir + sayiIki;
    Console.WriteLine("Toplam: " + toplam);
}



int ToplaReturn()
{
    Console.WriteLine("sayı bir: ");
    int sayiBir = int.Parse(Console.ReadLine());

    Console.WriteLine("sayı iki: ");
    int sayiIki = int.Parse(Console.ReadLine());

    int toplam = sayiBir + sayiIki;
   
    return toplam;

}


//Kullanıcıdan adını ve soyadını alın. Geriye ad ve soyad ile birlikte mail adresi döndürün.

void EpostaOlustur()
{
    Console.WriteLine("Ad: ");
    string ad=Console.ReadLine();
    Console.WriteLine("Soyad: ");
    string soyad=Console.ReadLine();

    string eposta = ad + "." + soyad + "@gmail.com";

    Console.WriteLine(eposta);
     
}

string EpostaOlusturReturn()
{
    Console.WriteLine("Ad: ");
    string ad = Console.ReadLine();
    Console.WriteLine("Soyad: ");
    string soyad = Console.ReadLine();

    string eposta = ad + "." + soyad + "@gmail.com";

    return eposta;
}


//EpostaOlustur();
//Console.WriteLine("Eposta oluşturuldu!");



//Console.WriteLine("////////////////");

//string sonuc=EpostaOlusturReturn() + " Eposta oluşturuldu";//geriye eposta fırlatır.

//Console.WriteLine(sonuc);


//Kullanıcıdan bir sayı alın. alınan sayıya 10 ekleyin.


//void ToplaVeEkle()
//{
//    Console.WriteLine("sayı girin: ");
//    int sayi=int.Parse(Console.ReadLine());

//    int toplam = sayi + 10;

//}

//int ToplaveFırlat()
//{
//    Console.WriteLine("sayı girin: ");
//    int sayi = int.Parse(Console.ReadLine());
//    return sayi;
//}

//ToplaVeEkle();

//int toplam=ToplaveFırlat()+10;

//Kullanıcıdan alınan sayı çift ise kullanıcının epostasını oluştur.

//int SayiFirlat()
//{
//    Console.WriteLine("Sayı: ");
//    int gelenSayi = int.Parse(Console.ReadLine());

//    if (gelenSayi % 2 == 0)
//    {
//        return 0;
//    }
//    else
//    {
//       return 1;
//    }

//}

//if (SayiFirlat() == 0)
//{
//    EpostaOlustur();
//}

//Console.Read();

//geriye şehirleri dönen metot oluşturun.

string[] SehirleriGetir()
{
    string[] sehirler = { "İstanbul", "Ankara", "İZmir" };
    return sehirler;
}


foreach(string sehir in SehirleriGetir())
{
    Console.WriteLine(sehir);
}
