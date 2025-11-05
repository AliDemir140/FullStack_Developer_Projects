/*
    1-Encapsulation
    2-Polymoprhism
    3-Inheritance
    4-Abstraction => Soyutlama
 */

/*
 Müzik Grubu
 Müzisyen => Enstruman
 
    Arda => Gitar
    Hakan=> Mızıka
    Muhammet => Bateri
    Ali=> Bağlama

Uygulama çalıştığında ekran'da aşağıdaki gibi bir çıktı alın.
    
    Müzisyenler
    Arda
    Hakan
    Muhammet
    Ali

    Enstrumanlar
    Gitar
    Mızıka
    Bateri
    Bağlama

gitar.Cal();
Arda Gitar çalıyor...

mizika.Cal();
Hakan Mızıka çalıyor...


 */


using CA_Abstraction;

Gitar gitar=new Gitar();
gitar.Marka = "Fender";
gitar.Perdeli = true;


Mizika mizika=new Mizika();
mizika.Marka = "ASD";

//Muzisyenler

Müzisyen m1 = new Müzisyen();

m1.Ad = "Hakan";
m1.Enstruman = mizika;

Console.WriteLine(m1.Enstruman.Cal());


Müzisyen m2 = new Müzisyen();
m2.Ad = "Arda";
m2.Enstruman = gitar;
Console.WriteLine(m2.Enstruman.Cal());


//Somut => ince belli çay bardağı, Messi
//Soyut => Bardak, Futbolcu

Gitar gitar2=new Gitar();
gitar2.Marka = "asdad";


List<Enstruman> enstrumanLsitesi = new List<Enstruman>();
enstrumanLsitesi.Add(gitar); //boxing
enstrumanLsitesi.Add(mizika); //boxing


foreach (Enstruman item in enstrumanLsitesi)
{
   //unboxing
   if(item is Gitar)
    {
        Gitar gelenGitar = (Gitar)item; //cast
        Console.WriteLine(gelenGitar.Perdeli);
    }
   else if(item is Mizika)
    {
        Mizika gelenMizika = (Mizika)item;
    }
}


