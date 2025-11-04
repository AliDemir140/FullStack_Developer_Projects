//Geriye değer döndürmeyen parametre alan metot.
//Bu tür metotlar void anahtar kelimesi ile tanımlanırlar fakat dışarıdan herhangi bir veri alabilirler.

void ReyonBilgisiYaz(string reyonAd)
{
    Console.WriteLine($"{reyonAd} reyonuna hoşgeldiniz");
}

//Dışarıdan gönderilen ürün ad,birim fiyatını, adeti hesaplayarak toplam ödenmesi gereken tutarı console'da gösteren metot.

string[] urunler = { "Ayakkabı", "Elma", "Bilgisayar" };
decimal[] fiyatlar = { 1000, 50, 50000 };
int[] adetler = { 2, 5, 1 };

void Hesapla(string urunAd, decimal fiyat, int adet)
{
    decimal toplam = fiyat * adet;

    Console.WriteLine($"{urunAd} toplam fiyat. {toplam}");
}

void UrunSiparisHesapla()
{
    for (int i = 0; i < urunler.Length; i++)
    {
        Hesapla(urunler[i], fiyatlar[i], adetler[i]);
    }
}


//Console çalıştığında kullanıcıyı adı ile karşılayan (Console'da yazdıran) metot.
void KullaniciKarsile(string kullaniciAd)
{
    Console.WriteLine($"{kullaniciAd} hoşgeldin!");
}

//Kullanıcıdan alınan 2 adet sayı ve bu sayılara uygulanacak işlemi dışarıdan alan ve sonucu console'da gösteren metot.

void IslemGerlestir(int s1, int s2, char islem)
{
    int sonuc = 0;

    try
    {
        switch (islem)
        {
            case '+':
                sonuc = s1 + s2;
                break;

            case '-':
                sonuc = s1 - s2;
                break;

            case '/':
                sonuc = s1 / s2;
                break;

            case '*':
                sonuc = s1 * s2;
                break;

            case '%':
                sonuc = s1 % s2;
                break;

            default:
                Console.WriteLine("Tanımsız işlem!");
                break;
        }
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.WriteLine($"İşlem Sonucu: "+sonuc);
}



////Metot Çağrısı
//ReyonBilgisiYaz("Manav");
//ReyonBilgisiYaz("Giyim");
//ReyonBilgisiYaz("Şarkuteri");

//Hesapla("Ayakkabı", 1000, 2);
//Hesapla("Elma", 50, 5);
//Hesapla("Bilgisayar", 50000, 1);
//UrunSiparisHesapla();
//IslemGerlestir(3, 2, '*');
//IslemGerlestir(10, 5, '/');
//IslemGerlestir(5, 6, '+');



Console.WriteLine("Sayı 1:");
int sayi1 = int.Parse(Console.ReadLine());

Console.WriteLine("Sayı 2:");
int sayi2 = int.Parse(Console.ReadLine());



Console.WriteLine("İşlem:");
char islem = char.Parse(Console.ReadLine());

IslemGerlestir(sayi1, sayi2, islem);