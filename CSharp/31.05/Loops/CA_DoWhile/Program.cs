
//Do While
/*
    Do While dööngüsü while döngüsü ile aynı prensibe sahiptir. Ancak, tek farkı do while döngüsü koşul her ne olursa olsun enb az bir kez çalışır.

 */

//1'den 10'a kadar console'da sayıları yazdırın.

//int i = 1;
//while (i<=10)
//{
//    Console.WriteLine(i);
//    i++;
//}

//
//do
//{
//    Console.WriteLine(i);
//    i++;
//} while (i <= 10);

//1000'den 1'e kadar sayıları console'da yazdırın.
//int i = 1000;

//do
//{

//    Console.WriteLine(i);
//    i--;
//} while (i >= 0);


//Kullanıcıdan 5 kez değer alın alınan değerleri en sonda console'da gösterin.




//string deger="";

//int i =0;

//do
//{
//    Console.WriteLine("Değer girin: ");
//    deger += Console.ReadLine() + " ";
//    i++;
//} while (i < 5);
//Console.WriteLine(deger);

//

//uygulama çalıştığında kullanıcı adı "admin" şifre "1234" olan bilgiler girildiğinde console'da bir sayı alınsın. sayının tek mi çift mi olduğu tekrar console'da gösterilsin.


///aşağıdaki işlem bir kez.
//kullanıcı adı:
//admin
//şifre:
//1234

///aşağıdaki işlem tekrarlı gerçekleşecek.
//sayı: 5
//sayı tek
//tekrar sayı girilsin mi? (e/h)


//string kullaniciAd = "admin";
//string sifre = "1234";

//string gelenKullaniciAd = "";
//string gelenSifre = "";

//int gelenSayi = 0;

//Console.WriteLine("kullanıcı ad: ");
//gelenKullaniciAd = Console.ReadLine();
//Console.WriteLine("şifre: ");
//gelenSifre=Console.ReadLine();

//bool devam = false;

//if (gelenKullaniciAd == kullaniciAd && gelenSifre == sifre)
//{
//    do
//    {
//        Console.WriteLine("sayı girin: ");
//        gelenSayi = int.Parse(Console.ReadLine());
//        if (gelenSayi % 2 == 0)
//        {
//            Console.WriteLine("Sayı Çift");
//        }
//        else
//        {
//            Console.WriteLine("Sayı Tek");
//        }

//        Console.WriteLine("işlem devam etsin mi? (e/h)");
//        string secim= Console.ReadLine();
//        if (secim == "e")
//        {
//            devam = true;
//        }
//        else
//        {
//            devam = false;
//        }



//    }while(devam);
//}
//else
//{
//    Console.WriteLine("bilgileriniz yanlış!");
//}

//aşağıdaki gibi bir menü oluşturun.

/*
 1-Bakiye Görüntüle
 2-Para Yükle
 3-Para Çek
 4-Çıkış
seçim: 2

 */

//kullanıcıdan bir seçim değeri alınacak. Bu değere göre işlemler Do while döngü kullanılarak gerçekleştirilecek. Bakiye 1000 TL olarak tanımlanacak.

decimal bakiye = 1000;

string menu = "1-Bakiye Gönrütüle\n2-Para Yükle\n3-Para Çek\n4-Çıkış";
string secim = "";
decimal gelenDeger = 0;


do
{
    Console.WriteLine(menu);
   secim= Console.ReadLine();
    //Karar Yapısı
    switch (secim)
    {
        case "1":
            Console.WriteLine("Bakiyeniz: "+bakiye);
            break;

        case "2":
            Console.WriteLine("değer: ");
            gelenDeger = Convert.ToDecimal(Console.ReadLine());//100
            bakiye += gelenDeger;
            Console.WriteLine("Bakiyeniz: "+bakiye);

            break;

        case "3":
            Console.WriteLine("değer: ");
            gelenDeger = Convert.ToDecimal(Console.ReadLine());//100
            if (gelenDeger <= bakiye)
            {
                bakiye -= gelenDeger;
                Console.WriteLine("Bakiyeniz: " + bakiye);
            }
            else
            {
                Console.WriteLine("Bakiyeniz yetersiz!!!");
            }
            break;

        case "4":
            Console.WriteLine("Çıkış yapılıyor...");
            
            break;

        default:
            Console.WriteLine("Geçersiz işlem. Lütfen 1 ile 4 arasında değer girin");
            break;
    }
} while (secim!="4");

Console.WriteLine("Uygulama sonlandırıldı!");