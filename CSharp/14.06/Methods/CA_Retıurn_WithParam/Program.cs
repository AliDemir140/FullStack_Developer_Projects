//Geriye Değer Döndüren=> Parametre Alan

//dışarıdan iki adet sayı alan ve geriye toplamı döndüren metot.

int ToplaParametreli(int s1,int s2)
{
    return s1 + s2;
}

int toplam=ToplaParametreli(5, 3);

Console.WriteLine(toplam);

Console.WriteLine(ToplaParametreli(5,5));

///

//Console çalıştığında kullanıcının adını alın, eğer sabah saaatlerinde ise "Günaydın ....", Akşam saatlerinde ise "İyi akşamlar ....." ise sonucunu döndüren metot.

//00:00 => 12:00 => günaydın
//12:00=>23:00 => İyi akşamlar


string Selamla(string ad)
{
   int saat= DateTime.Now.Hour;
    string mesaj = "";

    if(saat>0 && saat < 12)
    {
        mesaj = "Günaydın " + ad;
    }
    else
    {
        mesaj = "İyi Akşamlar " + ad;
    }
    return mesaj;
}

Console.WriteLine(Selamla("Fatih"));
Console.WriteLine(Selamla("Ali"));
Console.WriteLine(Selamla("Hakan"));


