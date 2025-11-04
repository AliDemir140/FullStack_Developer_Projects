
#region Faz 1
//Kullanıcıdan bir değer alın. Alınan değer
//domates, biber, patlıcan ise "Manav reyonumuz zemin kattadır"
//telefon, tablet, bilgisayar ise "Teknoloji reyonumuz 1. kattadır"
//tshirt, pantolon, gömlek ise "Giyim reyonumuz 2. kattadır"
//bunların haricinde bir değer gelirse "böyle bir reyonumuz bulunmamaktadır"
//uyarısını console'da kullanıcıya gösterin. 
#endregion

//string gelenDeger = "";
//Console.WriteLine("değer girin: ");
//gelenDeger = Console.ReadLine();
//if (gelenDeger == "domates" || gelenDeger == "biber" || gelenDeger == "patlıcan")
//{
//    Console.WriteLine("Manav reyonumuz zemin kattadır.");
//}
//else if (gelenDeger == "telefon" || gelenDeger == "tablet" || gelenDeger == "bilgisauar")
//{
//    Console.WriteLine("Teknoloji reyonumuz 1. kattadır");
//}
//else if (gelenDeger == "tshirt" || gelenDeger == "pantolon" || gelenDeger == "gömlek")
//{
//    Console.WriteLine("Giyim reyonumuz 2. kattadır");
//}
//else
//{
//    Console.WriteLine("böyle bir reyonumuz bulunmamaktadır");
//}

#region Faz 2
//Kulllanıcıya bakiye tanımlayın 1000 TL
//1-Domates 30 TL
//2-biber 25 TL
//3-patlıcan 50 TL
//seçim: 2


//1-telefon 1000 TL
//2-tablet 2000 TL
//3-bilgisayar 10000 TL
//seçim: 3
//bakiyeniz yetersiz!!!

//1-tshirt 100 TL
//2-pantolon 200 TL
//3-gömlek 150 TL
//seçim: 2 
#endregion
decimal bakiye = 1000;
string gelenDeger = "";
Console.WriteLine("değer girin: ");
gelenDeger = Console.ReadLine();
if (gelenDeger == "domates" || gelenDeger == "biber" || gelenDeger == "patlıcan")
{
    Console.WriteLine("Manav reyonumuz zemin kattadır.");
    Console.WriteLine("1-Domates 30TL");
    Console.WriteLine("2-Biber 25TL");
    Console.WriteLine("3-Patlıcan 50TL");
    Console.WriteLine("seçim: ");
    string secim = Console.ReadLine();

    if (secim == "1")
    {
        bakiye = bakiye - 30;
        Console.WriteLine("Domates sepete eklendi. Güncel bakiyeniz: "+bakiye);
    }
    else if (secim == "2")
    {
        bakiye = bakiye - 25;
        Console.WriteLine("biber sepete eklendi. Güncel bakiyeniz: " + bakiye);
    }
    else if (secim == "3")
    {
        bakiye = bakiye - 50;
        Console.WriteLine("Patlıcan sepete eklendi. Güncel bakiyeniz: " + bakiye);
    }
    else
    {
        Console.WriteLine("geçersiz seçim");
    }

}
else if (gelenDeger == "telefon" || gelenDeger == "tablet" || gelenDeger == "bilgisauar")
{
    //todo: işlemler gerçekleştirilecek
    Console.WriteLine("Teknoloji reyonumuz 1. kattadır");
}
else if (gelenDeger == "tshirt" || gelenDeger == "pantolon" || gelenDeger == "gömlek")
{
    //todo: işlemler gerçekleştirilecek
    Console.WriteLine("Giyim reyonumuz 2. kattadır");
}
else
{
    Console.WriteLine("böyle bir reyonumuz bulunmamaktadır");
}