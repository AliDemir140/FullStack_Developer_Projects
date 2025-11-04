//Geriye değer döndüren ve parametre almayan

//Bu tür metotlar "void" olarak tanımlanmazlar. Bunun yerine hangi değeri dönecek o değeri ait tip ile tanımlanırlar.

///Örnekler:
///
//Kullanıcıya 1000 ile 10000 arasında rastgeel sayı döndüren metot.




int RastgeleSayiOlustur()
{
    Random rnd = new Random();//instance => bir nesnenin örneğini ram üzerine çıkarma

    int rastgeleSayi = rnd.Next(1000, 10000);
    return rastgeleSayi;
}

//Metot Çağrısı

Console.WriteLine(RastgeleSayiOlustur());

//Eğer oluşturulan sayı 5000'den büyük ise kullanıcıya uyarı mesajı gösterin.

if (RastgeleSayiOlustur() > 5000)
{
    Console.WriteLine("sayı 5000'den büyük");
}

//Kargo ücretini geriye döndüren metot
decimal KargoUcret()
{


    string[] kargoSirketleri = { "MNG", "Aras", "Yurtiçi" };
    decimal fiyat = 0;

    Console.WriteLine("bir kargo firması girin: ");
    string gelenFirma = Console.ReadLine();



    foreach (string kargoSirket in kargoSirketleri)
    {
        switch (gelenFirma)
        {
            case "MNG":
                fiyat = 10;
            break;

            case "Aras":
                fiyat = 20;
                break;

            case "Yurtiçi":

                fiyat = 30;
                break;
        }
        break;
    }

    return fiyat;
}

Console.WriteLine(KargoUcret());