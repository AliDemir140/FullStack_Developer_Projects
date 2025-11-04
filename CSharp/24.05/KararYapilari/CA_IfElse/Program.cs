
//Kullanıcıdan bir kullanıcı adı bir dee şifre alın. Kullanıcı adı "admin" şifre "1234" ise ekranda True değerini eğer bilgiler hatalı ise ekranda False değerini gösterin.


//string username = "admin";
//string password = "1234";


//Console.WriteLine("kullanıcı adı girin: ");
//string gelenKullaniciAd = Console.ReadLine();//admin
//Console.WriteLine("şifre girin: ");
//string gelenSifre = Console.ReadLine();//1234

//bool sonuc = gelenKullaniciAd == username && gelenSifre == password;//True, False




//Karar Yapıları: içerisinde bool tip barındıran bir koşul gerçekleştirmek istediğimizde bu koşulu ilk etapta 2 farklı seçenek ile belirleriz.
//Ya işlem doğrudur ve doğru olduğu farklı bir yapı tetiklenir.
//Ya da işlemn yanlıştır yanlış olduğunda farklı bir yapı tetiklenir.


//If koşulu bizden değer olarak her zaman TRUE değerini bekler. Eğer sonuç false olursa if scope'u çalışmaz!!! 

//if (sonuc)//True
//{
//    Console.WriteLine("Bilgiler doğru");
//    Console.WriteLine("işlem devam ediyor.");

//}
//else//False
//{
//    Console.WriteLine("bilgileriniz hatalı");
//    Console.WriteLine("işlem durduldu.");
//}


//Kullanıcıdan bir değer alın bu değer "kırmızı", "red" ise console'da "DUR" yazsın. harici bir değer gelirse "Devam et" yazsın.


//Console.WriteLine("bir renk girin: ");
//string gelenRenk= Console.ReadLine().ToLower();

//bool renkSonuc = gelenRenk == "KIRMIZI" || gelenRenk == "RED";

//if (renkSonuc)//TRUE
//{
//    Console.WriteLine("DUR");
//}
//else
//{
//    Console.WriteLine("Devam Et");
//}

//Kullanıcıdan bir değer alın bu değer "kırmızı", "red" ise console'da "DUR", "Sarı", "Yellow" ise "Bekle", "Yeşil","Green" ise "Devam et" mesajını console'da kullanıcıya gösterin.

//if (gelenRenk=="KIRMIZI"||gelenRenk=="RED")//TRUE
//{
//    Console.WriteLine("DUR");
//}
//else if(gelenRenk=="SARI"||gelenRenk=="YELLOW")//TRUE
//{
//    Console.WriteLine("Bekle");
//}
//else if(gelenRenk=="YEŞİL"||gelenRenk=="GREEN")
//{
//    Console.WriteLine("Devam Et");
//}
//else
//{
//    Console.WriteLine("böyle bir trafik ışığı duymadım. İstediğini yap");
//}

//Kullanıcıdan bir sayı alın bu sayı tek ise "Sayı tektir" çift ise "Sayı çifttir" uyarısını console'da gösterin.

//try
//{
//    Console.WriteLine("sayı girin: ");
//    int gelenSayi = int.Parse(Console.ReadLine());

//    if (gelenSayi % 2 == 0) //% Mod almak: bir sayıyı bir sayıya bölündüğünde geriye kalan sayı.
//    {
//        Console.WriteLine("Sayı çift");
//    }
//    else
//    {
//        Console.WriteLine("Sayı tektir");
//    }

//}
//catch
//{
//    Console.WriteLine("dönüşüm işleminde hata meydana geldi");
//}

//Uygulama çalıştığında Kullanıcı adı admin ve şifre 1234 olan bir kullanıcı tanımlayın. kullanıcı başarılı şekilde giriş yaptıktan sonra o kullanıcıya 1000 TL'lik bakiye oluşturun. Eğer giriş başarısız ise bakiye 0 olacak. 
//kullanıcı console'dan bir tercih yapabilmeli. Bu tercih aşağıdaki gibi olmalı.
//1-Para çek
//2-Para yatır
//Kullanıcı 1'i seçtiğinde console'a bir değer tanımlamalı bu değer bakiyeden azaltılmalı.
//Kullanıcı 2'i seçtiğinde console'a bir değer tanımlamalı bu değer bakiyeye dahil edilerel aktarılmalı.

//İşlem anında runtime hatası alınmamalı.

//string kullaniciAd = "admin";
//string sifre = "1234";
//decimal bakiye = 0;
//string secim = "";
//decimal tutar = 0;


//Console.WriteLine("Kullanıcı adı girin: ");
//string gelenKullaniciAd = Console.ReadLine();

//Console.WriteLine("Şifre girin: ");
//string gelenSifre = Console.ReadLine();

//bool girisSonuc = gelenKullaniciAd == kullaniciAd && gelenSifre == sifre;

//if (girisSonuc)
//{
//    bakiye = 1000;

//    //İşlem Menüsü
//    Console.WriteLine("***İşlem Menu***");
//    Console.WriteLine("1-Para Çek");
//    Console.WriteLine("2-Para Yatır");
//    Console.Write("seçim: ");
//    secim = Console.ReadLine();
//    //Eğer girilen değer 1 veya 2 ise o değerlere ait işlem gerçekleştirilecek.



//    try
//    {
//        if (secim == "1")
//        {
//            Console.WriteLine("Çekilecek tutarı girin: ");
//            tutar = decimal.Parse(Console.ReadLine());//patates
//            bakiye = bakiye-tutar;//todo: tutar kontrol edilmeli bakiyeye eşit ya da bakiyeden az olmalı.
//            Console.WriteLine("güncel bakiyeniz: "+bakiye);

//        }
//        else if (secim == "2")
//        {
//            Console.WriteLine("Yatırılacak Tutar: ");
//            tutar = decimal.Parse(Console.ReadLine());
//            bakiye += tutar;//todo: kullanıcı eksi bir değer girmemeli!
//            Console.WriteLine("güncel bakiyeniz: "+bakiye);
//        }
//        else
//        {
//            Console.WriteLine("tanımsız işlem");
//        }
//    }
//    catch (Exception ex)
//    {

//        Console.WriteLine(ex.Message);
//    }



//}
//else
//{
//    Console.WriteLine("bilgileriniz yanlış Bakiyeniz: " + bakiye);
//}


//"Domates bedeli 30 bakiyeniz 970 TL kaldı"









