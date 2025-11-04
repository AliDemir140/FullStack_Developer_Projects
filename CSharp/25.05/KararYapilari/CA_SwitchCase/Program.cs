//Switch Case: bir karar yapısıdır ancak if else bloklarında olduğu gibi her bir koşulu kontrol ederek kararı vermez. Bunun yerine ilk olarak hangi değere göre bir işlem gerçekleşecekse öncelikle o değri önbelleğe alır ardından case içerisinde önbelleğe aldığı değerin eşitliğine göre kararı gerçekleştirir.

//Kullanıcıdan bir mevsim değeri alın. Ayları gösterin.
//Yaz
//Haziran, Temmuz, Ağustos

//İlkbahar
//Mart, Nisan, Mayıs

//Kış
//Aralık, Ocak, Şubat

//Sonbahar
//Eylül, Ekim, Kasım

//Böyle bir mevsim duymadım.

//const: sabit anlamında kullanılan. Değişken değeri değiştirelemez!!!

//string gelenMevsim = "";

//const string yazAylari = "Haziran, Temmuz, Ağustos";
//const string kisAylari = "Aralık, Ocak, Şubat";
//const string sonbaharAylari = "Eylül, Ekim, Kasım";
//const string ilkbaharAylari = "Mart, Nisan, Mayıs";

//Console.WriteLine("bir mevsim girin: ");
//gelenMevsim = Console.ReadLine().ToLower();//sıcak

//#region Karar yapısı
//////
////if (gelenMevsim == "yaz")
////{
////    Console.WriteLine(yazAylari);
////}
////else if (gelenMevsim == "kış")
////{
////    Console.WriteLine(kisAylari);
////}
////else if (gelenMevsim == "sonbahar")
////{
////    Console.WriteLine(sonbaharAylari);
////}
////else if (gelenMevsim == "ilkbahar")
////{
////    Console.WriteLine(ilkbaharAylari);
////}
////else
////{
////    Console.WriteLine("böyle bir mevsim duymadım!");
////} 
//#endregion


//switch (gelenMevsim)
//{
//    case "yaz":
//    case "sıcak":
//    case "güneş":


//        //işlem
//        Console.WriteLine(yazAylari);
//        break; //işlemin sonlandırılmasını sağlayan anahtar komuttur.

//    case "kış":
//        //işlem
//        Console.WriteLine(kisAylari);
//        break;

//    case "sonbahar":
//        //işlem
//        Console.WriteLine(sonbaharAylari);

//        break;

//    case "ilkbahar":
//        //işlem
//        Console.WriteLine(ilkbaharAylari);
//        break;

//    default:
//        Console.WriteLine("böyle bir mevsim duymadım!");
//        break;

//}

//kullanıcıdan bir kullanıcı adı ve şifre değeri alın kullanıcı adı "admin" şifre "1234" ise "Hoşgeldin",
//kullanıcı adı "admin" ancak şifre yanlış ise "kullanıcı adınız doğru ancak şifreniz yanlış"
//kullanıcı adı yanlış ise "kullanıcı adınız yanlış, şifreye bakmadım bile" 
//mesajını console'da gösterin.

//string gelenKullaniciAd = "";
//string gelenSifre = "";

//Console.WriteLine("kullanıcı adı: ");
//gelenKullaniciAd=Console.ReadLine().ToLower();





//IF Else
//if (gelenKullaniciAd == "admin")
//{
//    Console.WriteLine("şifre: ");
//    gelenSifre = Console.ReadLine();

//    if (gelenSifre == "1234")
//    {
//        Console.WriteLine("Hoşgeldin!");
//    }
//    else
//    {
//        Console.WriteLine("Kullanıcı adınız doğru ancak şifreniz yanlış");
//    }
//}
//else
//{
//    Console.WriteLine("kullanıcı adınız yanlış, şifreye bakmadım bile");
//}


//Switch Case

//switch (gelenKullaniciAd)
//{
//    case "admin":
//        Console.WriteLine("şifre: ");
//        gelenSifre = Console.ReadLine();

//        switch (gelenSifre)
//        {
//            case "1234":
//                Console.WriteLine("Hoşgeldin!");
//                break;

//            default:
//                Console.WriteLine("Kullanıcı adınız doğru ancak şifreniz yanlış");
//                break;
//        }

//        break;

//    default:
//        Console.WriteLine("kullanıcı adınız yanlış, şifreye bakmadım bile");
//        break;
//}

//Uygulama çalıştığında aşağıdaki menü kullanıcıya gösterilsin.




/*
    İşlem Menu
1-Ürün İşlemleri
2-Kategori İşlemleri
3-Müşteri İşlemleri
4-Sipariş İşlemleri
seçim: 1

1-Ürün Ekle
2-Ürün Listele


1-Sipariş Listele



 */


string secim = "";

string menu = "1-Ürün İşlemleri\n2-Kategori İşlemleri\n3-Müşteri İşlemleri\n4-Sipariş İşlemleri";

string urunMenu = "1-Urun Ekle\n2-Ürün Listele";

string kategoriMenu = "1-Kategori Ekle\n2-Kategori Listele";

string musteriMenu = "1-Musteri Ekle\n2Musteri Listele";

string siparisMenu = "1-Sipariş Listele";

string errorMessage = "hatalı işlem";

string gelenKullaniciAd = "";
string gelenSifre = "";

Console.WriteLine("Kullanıcı ad: ");
gelenKullaniciAd=Console.ReadLine();

switch (gelenKullaniciAd)
{
    case "admin":
        Console.WriteLine("şifre: ");
        gelenSifre = Console.ReadLine();

        switch (gelenSifre)
        {
            case "1234":
                #region Menu İşlemleri

                Console.WriteLine(menu);

                Console.WriteLine("seçim: ");
                secim = Console.ReadLine();

                //Karar Yapısı
                switch (secim)
                {
                    case "1":
                        Console.WriteLine(urunMenu);
                        Console.Write("seçim: ");
                        secim = Console.ReadLine();

                        //Karar Yapısı (Ürün Menu)

                        switch (secim)
                        {
                            case "1":
                                Console.WriteLine("Ürün Ekleme İşlemi");
                                break;

                            case "2":
                                Console.WriteLine("Ürün Listeleme İşlemi");
                                break;

                            default:
                                Console.WriteLine(errorMessage);
                                break;
                        }

                        break;
                    case "2":
                        Console.WriteLine(kategoriMenu);
                        Console.Write("seçim: ");
                        secim = Console.ReadLine();
                        switch (secim)
                        {
                            case "1":
                                Console.WriteLine("Kategori Ekleme İşlemi");
                                break;

                            case "2":
                                Console.WriteLine("Kategori Listeleme İşlemi");
                                break;

                            default:
                                Console.WriteLine(errorMessage);
                                break;
                        }
                        break;

                    case "3":
                        Console.WriteLine(musteriMenu);
                        Console.Write("seçim: ");
                        secim = Console.ReadLine();
                        switch (secim)
                        {
                            case "1":
                                Console.WriteLine("Müşteri Ekleme İşlemi");
                                break;

                            case "2":
                                Console.WriteLine("Müşteri Listeleme İşlemi");
                                break;

                            default:
                                Console.WriteLine(errorMessage);
                                break;
                        }

                        break;

                    case "4":
                        Console.WriteLine(siparisMenu);
                        Console.Write("seçim: ");
                        secim = Console.ReadLine();
                        switch (secim)
                        {
                            case "1":
                                Console.WriteLine("Sipariş Listeleme İşlemi");
                                break;

                            default:
                                Console.WriteLine(errorMessage);
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine(errorMessage);
                        break;
                }




                #endregion
                break;

            default:
                Console.WriteLine("Kullanıcı adınız doğru ancak şifreniz yanlış");
                break;
        }

        break;

    default:
        Console.WriteLine("kullanıcı adınız yanlış, şifreye bakmadım bile");
        break;
}




Console.Read();



