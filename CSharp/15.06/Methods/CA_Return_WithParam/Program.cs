//Kargo ücretini geriye döndüren metot
decimal KargoUcret(string kargoFirma)
{


    string[] kargoSirketleri = { "MNG", "Aras", "Yurtiçi" };
    decimal fiyat = 0;




    foreach (string kargoSirket in kargoSirketleri)
    {
        switch (kargoFirma)
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

Console.WriteLine(KargoUcret("MNG"));
Console.WriteLine(KargoUcret("Aras"));
Console.WriteLine(KargoUcret("Yurtiçi"));