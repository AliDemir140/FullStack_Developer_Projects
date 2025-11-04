//Döngüler

//C# programlama dilinde yapısal olarak 4 farklı döngü mantığı bulunmaktadır.
//1-While Döngüsü:
//2-Do While Döngüsü:
//3-For Döngüsü:
//Dizi (array)
//4-Foreach Döngüsü:


//Ekrana 10 kez merhaba dünya ifadesini yazdıran algoritma.
//1-Başla
//2-sayac tanımla (1)
//3-sayac kontrol et
//sayac 10'dan küçük mü?
//Evet
//Ekrana merhaba dünya yaz sayacı artır.
//Hayır
//Uygulamayı durdur

//int i = 0; //iterasyon
//while (i<10)
//{
//    Console.WriteLine("Merhaba Dünya");
//    i++;    
//}

//1'den 100'a kadar tek sayıların toplamı ile çift sayıların toplamını ekranda gösterin.

//Tek Sayıların Toplamı: 
//Çift Sayıların Toplamı: 

int tekToplam = 0;
int çiftToplam = 0;

int i = 1;

while (i <= 100)
{
    if (i % 2 == 0)
    {
        //çift
        çiftToplam += i;
    }
    else
    {
        //tek
        tekToplam += i;
    }
    i++;
}

Console.WriteLine("Tek Toplam: "+tekToplam);
Console.WriteLine("Çift Toplam: "+çiftToplam);