//Geriye Değer Döndürmeyen=> Parametre Almayan
//void anahtar kelimesi bir metodun geriye değer döndürmediğini temsil eder.
//Şu ana kadar gördüğümüz her şeyi her şey içersinde kullanabiliriz.


//Metotlar genellikle emir kipi ile isimlendirilir.
//Metot isimleri PascalCase tanımlanmalıdır. 
//Eylem

//Metot Tanımlama

//Kullanıcıyı selamlayan metot.
void Selamla()
{
    Console.WriteLine("Merhaba!");
}

//Kullanıcıdan değer alan metot. Kullanıcıdan bir değer alarak alınan değeri console'da gösterin.

void KullanicidanDegerAl()
{
    Console.WriteLine("bir değer girin: ");
    string gelenDeger = Console.ReadLine();
    Console.WriteLine(gelenDeger); 

}

//Kullanıcıdan alınan değerin tek mi cift mi olduğunu gösteren metot.
void TekCiftKontrol()
{
	try
	{
        Console.WriteLine("bir sayı girin");
        int gelenSayi = int.Parse(Console.ReadLine());

        //Karar Yapısı
        if (gelenSayi % 2 == 0)
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

//console uygulaması çalıştığında kullanıcıya 3 farklı menü gösterilsin. Kullanıcı menüden seçim yapsın. Yapılan seçim tekrar console'da gösterilsin.

/*
    1-A Menu
    2-B Menu
    3-C Menu
    seçim: 2
    B Menu

 */

void MenuSec()
{
    string[] menu = { "1-A Menu", "2-B Menu", "3-C Menu" };
    for (int i = 0; i < menu.Length; i++)
    {
        Console.WriteLine(menu[i]);
    }
    Console.WriteLine("seçim: ");
    int gelenSecim = int.Parse(Console.ReadLine());//

    if (gelenSecim < 0 || gelenSecim > menu.Length)
    {
        Console.WriteLine($"Lütfen 1 ile {menu.Length} aralığında değer girin");
    }
    else
    {
        Console.WriteLine($"Seçilen Menu {menu[gelenSecim-1]}");
    }
}


//1 ile 10 arasında çarpım tablosunu oluşturan metot. Parametre Almayan

void CarpimTablosuOlustur()
{
    for (int i = 1; i <= 10; i++)
    {
        for (int z = 1; z <=10; z++)
        {
            Console.WriteLine($"{i}x{z}={i*z}");
        }
        Console.WriteLine("--------------");
    }
}

//1 ile 100 arasında rastgele sayı oluşturan metot

void RastgeleSayiOlustur()
{
    Random rnd = new Random();
    int rastgeleSayi = rnd.Next(1, 101);
    Console.WriteLine(rastgeleSayi);
}




//Metot Kullanımı
//Selamla();
//KullanicidanDegerAl();
TekCiftKontrol();
CarpimTablosuOlustur();
RastgeleSayiOlustur();


//while (true)
//{
//    MenuSec();
//}