//Metotlar C# programlama dilinde bir işlemi tekrar tekrar gerçekleştirmek istediğimzide kullanıdığımız yapılardır. (Fonksiyon)

//void anahtar kelimesi bir metodun geriye değer döndürmediğini temsil eder. Yani void olarak tnaımlanan metot sadece gövdesindeki işlemi yerine getirir.


//Kullanım alanına göre 2 farklı metot bulunmaktadır.
///Geriye Değer Döndürmeyen
//Parametre alan
//Parametre almayan
///Geriye Değer Döndüren
//Parametre alan
//Parametre almayan

///Örnekler
///

void HosgeldinMesaji()
{
    Console.WriteLine("Projeye Hoşgeldiniz");
   
}

void CikisYazisi()
{
    Console.WriteLine("Bizi tercih ettiğiniz için teşekkür ederiz");
}

void BugununTarihi()
{
    Console.WriteLine($"Bugünün tarihi {DateTime.Now}");
}

void IslemBaslat()
{
    Console.WriteLine("İşlem başlatıldı");
}

//Metot Çağrıları

void Main()
{
    HosgeldinMesaji();
    CikisYazisi();
    BugununTarihi();
    IslemBaslat();
}

Main();