//Hayalinizdeki 4 futbolcuyu tanımlayın.
//1-Kaleci
//1-Defans
//1-OrtaSaha
//1-Forvet

//Bir liste içerisinde sakalanrak uygulama çalıştığında console'da futbolcular mevkiileri ile birlikte yazdırılacak.

using CA_FutbolTakimi;

List<Futbolcu> futbolTakimi=new List<Futbolcu>();

//Kaleci
Kaleci kaleci=new Kaleci();
kaleci.Ad = "Altay";
kaleci.Soyad = "Bayındır";
kaleci.TopKurtarmaGuc = 20;
kaleci.SutGuc = 85;

futbolTakimi.Add(kaleci);  

Defans defans=new Defans();
defans.Ad = "Virgil";
defans.Soyad = "Van Djink";
defans.SutGuc = 90;
defans.PresGuc = 95;
futbolTakimi.Add(defans);

OrtaSaha ortaSaha=new OrtaSaha();
ortaSaha.Ad = "Arda";
ortaSaha.Soyad = "Güler";
ortaSaha.OyunKurmaGuc = 100;
futbolTakimi.Add(ortaSaha);

Forvet forvet=new Forvet();
forvet.Ad = "Kylian";
forvet.Soyad = "Mbappe";
forvet.SutGuc = 95;
forvet.GolAtmaGuc = 98;
futbolTakimi.Add(forvet);

//Eğer Kalecinin Top kurtarma gücü 60'ın üzerindeyse kurtarma oranı başarılı.
//Eğer ortasahanın oyun kurma gücü 60'in üzerindeyse takım atak'a geçsin.
//Eğer Forvet'in gol atma gücü 80'in üzerinde ise gol olma olasılığı %60 artsın.



foreach (Futbolcu futbolcu in futbolTakimi)
{
    string oyuncuAd = "";
    string oyuncuSoyad = "";
    string futbolcuOZellikleri = "";

    if (futbolcu is Kaleci)
    {
        Kaleci k = (Kaleci)futbolcu;
        oyuncuAd = k.Ad;
        oyuncuSoyad= k.Soyad;
        futbolcuOZellikleri = k.TopKurtarmaGuc.ToString();
        Console.WriteLine(k.TopKurtar());
    }
    else if(futbolcu is Defans)
    {
        Defans d= (Defans)futbolcu;
        oyuncuAd = d.Ad;
        oyuncuSoyad=d.Soyad;
        futbolcuOZellikleri = d.PresGuc.ToString();
    }
    else if(futbolcu is OrtaSaha)
    {
        OrtaSaha ortaSaha1 = (OrtaSaha)futbolcu;
        oyuncuAd = ortaSaha1.Ad;
        oyuncuSoyad= ortaSaha1.Soyad;
        futbolcuOZellikleri=ortaSaha1.OyunKurmaGuc.ToString();
    }
    else if(futbolcu is Forvet)
    {
        Forvet f = (Forvet)futbolcu;
        oyuncuAd = f.Ad;
        oyuncuSoyad = f.Soyad;
        futbolcuOZellikleri=forvet.GolAtmaGuc.ToString();
        Console.WriteLine(f.SutCek());
    }

    Console.WriteLine(oyuncuAd+" "+oyuncuSoyad+" "+futbolcuOZellikleri);
}

