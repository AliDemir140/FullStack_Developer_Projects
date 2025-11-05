//Inheritance (Kalıtım/Miras)



using CA_Inheritance;

//C# programlama dilinde bir class sadece bir class'dan miras alabilir.

/*Anakart[] anakartReyon = new Anakart[2];*/ //ilkel koleksiyon

//Generic List
//List<Anakart> anakartListesi = new List<Anakart>();
//List<Islemci> islemciListei=new List<Islemci>();
//List<Ram> ramListesi = new List<Ram>();
//List<EkranKart> ekranKartListesi = new List<EkranKart>();
//List<Bilgisayar> bilgisayarListesi = new List<Bilgisayar>();

List<BaseClass> urunler=new List<BaseClass>(); //kutulama => boxing


//Anakartlar
Anakart anakart1=new Anakart();
anakart1.Marka = "Asus";
anakart1.Model = "adadad";
anakart1.Fiyat = 5000;

Anakart anakart2 = new Anakart();
anakart2.Marka = "MSI";
anakart2.Model = "adadad";
anakart2.Fiyat = 7000;

//anakartListesi[0]=anakart1;
//anakartListesi[1]=anakart2;

//anakartListesi.Add(anakart1);
//anakartListesi.Add (anakart2);
urunler.Add(anakart1);
urunler.Add(anakart2);


//İşlemciler
Islemci islemci1=new Islemci();
islemci1.Marka = "Intel";
islemci1.Cekirdek = 16;
islemci1.Model = "I9";
islemci1.Fiyat = 50000;

//islemciListei.Add(islemci1);
urunler.Add(islemci1);

//Ramler
Ram ram = new Ram();
ram.Marka = "Corsair";
ram.Model = "kafa1500";
ram.Kapasite = 32;
ram.Fiyat = 15000;

//ramListesi.Add(ram);
urunler.Add(ram);

//EkranKartlari
EkranKart ekranKart = new EkranKart();
ekranKart.Marka = "Nvidia";
ekranKart.Model = "4050";
ekranKart.Fiyat = 60000;
//ekranKartListesi.Add(ekranKart);
urunler.Add(ekranKart);

//Bilgisayarlar
Bilgisayar bilgisayar1=new Bilgisayar();
bilgisayar1.Anakart=anakart1;
bilgisayar1.EkranKart=ekranKart;
bilgisayar1.Ram=ram;
bilgisayar1.Islemci=islemci1;
bilgisayar1.Marka = "Oyuncu Pc1";
bilgisayar1.Fiyat = 150000;
//bilgisayarListesi.Add(bilgisayar1);
urunler.Add(bilgisayar1);


//Uurunler console'da gösterilmesi

foreach (BaseClass item in urunler)
{
    //boxing olarak tanımlanan nesneyi unboxing olarak kutudan çıkarılması gerekmektedir. Bu işleme "Cast" işlemi denilmektedir.
  
    //Console.WriteLine(item.);
    if(item is Anakart)
    {
        Anakart gelenAnakart= (Anakart)item;//unboxing
    }
    else if(item is EkranKart)
    {
        EkranKart gelenEkranKarti= (EkranKart)item;
    }
    else if(item is Ram)
    {
        Ram gelenRam= (Ram)item;
    }
    else if(item is Islemci)
    {
        Islemci gelenIslemci= (Islemci)item;
    }
    else if(item is Bilgisayar)
    {
        Bilgisayar gelenBilgisayar= (Bilgisayar)item;
    }
}







