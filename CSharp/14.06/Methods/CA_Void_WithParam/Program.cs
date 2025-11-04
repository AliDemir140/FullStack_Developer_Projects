
//Geriye Değer Döndürmeyen => Parametre Alan


//Metot Tanımlama
void Selamla(string ad)
{
    Console.WriteLine("Merhaba "+ad);
}

//Dışarıdan alınan sayının tek mi çift mi olduğunu kontrol eden metot.



void TekCiftKontrol(int sayi)
{
    try
    {
      

        //Karar Yapısı
        if (sayi % 2 == 0)
        {
            Console.WriteLine("Sayı Çift");
        }
        else
        {
            Console.WriteLine("Sayı Tek");
        }
    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
    }
}

//kullanıcıdan alınan değer kadar çarpım tablosunu oluşturan metot. Parametre Alan
void CarpimTablosuOlustur(int sayi)
{
    for (int i = 1; i <= sayi; i++)
    {
        for (int z = 1; z <= 10; z++)
        {
            Console.WriteLine($"{i}x{z}={i * z}");
        }
        Console.WriteLine("--------------");
    }
}

//kullanıcıdan alınan değer aralığında rastgele sayı oluşturan metot
void RastgeleSayiOlustur(int max)
{
    Random rnd = new Random();
    int rastgeleSayi=rnd.Next(1,max+1);
    Console.WriteLine(rastgeleSayi);
}


//Metot Kullanımı

Selamla("Fatih");
Selamla("Hakan");
Selamla("Ali");




while (true) {
    //Console.WriteLine("Bir Sayı Girin: ");
    //int gelenSayi = int.Parse(Console.ReadLine());
    //TekCiftKontrol(gelenSayi);
    //CarpimTablosuOlustur(50);
    RastgeleSayiOlustur(50);
    RastgeleSayiOlustur(30);
    Console.ReadLine();
}

