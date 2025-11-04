
//Sayı Tahmin Uygulaması
//seviye 1
//tahmin hak 5

//Uygulama çalıştığında console'da arkaplanda rastgele bir sayı oluşturun. 1 ile 10 (dahil) arasıdnda olacak. Başlangıç seviyesi 1

//kullanıcıdan bir tahmin istenmeli eğer bu tahmin arkaplanda tutulan sayı ile aynı ise "Tebrikler doğru tahmin" ifadesi console'da yazdırılacak.
//seviye birkez artırılacak. arka planda tutulan sayı 1 ile 20 (dahil) arasında olmalı
//tahmin hak 5 olarak güncellenecek.

//girilen sayı arkada tutulan sayıdan küçük ise "daha büyük bir sayı girin" yazacak.
//Tahmin hak bir kez azaltılacak.

//girilen sayı arkada tutulan sayıdan büyükse "daha küçük bir sayı girin"
//Tahmin hak bir kez azaltılacak.


//NOT: Bu işlem tek yönlü ilerler. yani işlem başa dönmez!!!


//Değişkenler
int tutulanSayi = 0;
int tahminEdilenSayi = 0;
int tahminHak = 5;
int seviyeCarpan = 10;
int seviye = 1;

//İşlem
Random rnd = new Random(); //instance
tutulanSayi = rnd.Next(1, seviye*seviyeCarpan+1);

try
{
    Console.WriteLine("**tutulan sayı: "+tutulanSayi);
    Console.WriteLine("Bir sayı girin: ");
    tahminEdilenSayi = int.Parse(Console.ReadLine());

    //Karar Yapısı
    if (tutulanSayi == tahminEdilenSayi)
    {
        Console.WriteLine("Tebrikler Doğru Tahmin!");
        tahminHak = 5;
        seviye++;//2
        tutulanSayi = rnd.Next(1, seviye * seviyeCarpan + 1);
        Console.WriteLine("Tutulan Yeni sayı: "+tutulanSayi);
    }
    else if (tahminEdilenSayi < tutulanSayi)
    {
        tahminHak--;
        Console.WriteLine("daha büyük bir sayı girin" + " tahmin hakkınız: " + tahminHak);
    }
    else if(tahminEdilenSayi>tutulanSayi)
    {
        tahminHak--;
        Console.WriteLine("daha küçük bir sayı girin"+" tahmin hakkınız: "+tahminHak);
    }

}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}

Console.Read();