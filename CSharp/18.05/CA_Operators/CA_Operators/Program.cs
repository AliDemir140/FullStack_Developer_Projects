//Operators (Operatörler)

#region Aritmetik Operatörler
/*
=  aktarma operatörü



+   toplama
-   çıkarma
*   çarpma
/   bölme
%   mod



*/
#endregion

//int sayiBir = 2;
//int sayiIki = 5;
#region Aritmetik İşlemler
//Console.WriteLine("iki adet sayının toplamı: ");
//Console.ReadLine();
//int toplam = sayiBir + sayiIki;
//Console.WriteLine(toplam);
//Console.WriteLine("iki adet sayının farkı: ");
//int fark = toplam - sayiBir;
//Console.WriteLine(fark);
//Console.ReadLine();

//Console.WriteLine("iki sayının modu: ");
//int mod = toplam % fark;
//Console.WriteLine(mod); 
#endregion



//Artırma/Azaltma Operatörleri
/*
    ++  değeri bir kez artırır
    --  değeri bir kez azaltır.
 
 */

//sayiBir++;
//sayiIki--;,


//int ornek1 = sayiBir++;
//int ornek2 = ++sayiBir;

//Console.WriteLine(sayiBir+sayiIki);




#region İlişkisel Operatörler


/*
 
    >   büyüktür
    <   küçüktür
    >=  büyük eşittir.
    <=  küçük eşittir
    ==  eşit eşittir.
    !=  eşit değildir.
 */
#endregion

#region İlişkisel Operatörler Örneği
////Ahmet'in yaşı 30 olsun, Ayşenin yaşı 25 olsun.  bilgiler şu an için doğru olarak kanul edilmektedir. Ancak bu bilgiler yanlış da olabilir. Bu yüzden ahmetin yaşı ayşenin yaşından büyük değil ise sonucu ekranda false olarak gösterin.

//int ahmetYas = 30;
//int ayseYas = 25;

//bool sonuc = ahmetYas > ayseYas;

//Console.WriteLine(sonuc); 
#endregion


#region Mantıksal Operatörler


///*
//   & VE
//   | VEYa (AltGr. <>)

//    &&  Mutlak VE
//    ||  Mutlak VEYA
// */ 
#endregion

//ahmet'in yaşı zeynep'in yaşından büyüktür. Aynı zamanda mehmetin yaşı ali'nin yaşından küçüktür. Bu bilgi dahilinde işlemin sonucunu console'da gösterin.

//int ahmetYas=30;
//int zeynepYas=20;
//int mehmetYas=18;
//int aliYas=25;

//bool result = ahmetYas > zeynepYas && mehmetYas < aliYas;


//Console.WriteLine(result);


//ahmet'in yaşı zeynep'in yaşından büyüktür. Aynı zamanda mehmetin yaşı ali'nin yaşından küçüktür. Bu bilgi dahilinde yaşları console ekranından kullanıcıdan alın.

//Değişkenler
//string ahmetYas = "";
//string zeynepYas = "";
//string mehmetYas = "";
//string aliYas = "";

//Console.Write("ahmet yaş: ");
//ahmetYas=Console.ReadLine();//bağlı bulunduğu satırın değerini okur
//Console.Write("zeynep yaş: ");
//zeynepYas=Console.ReadLine();
//Console.Write("mehmet yaş: ");
//mehmetYas=Console.ReadLine();
//Console.Write("ali yaş: ");
//aliYas=Console.ReadLine();

////Değerlerin gösterilmesi
//Console.Write("ahmet yaş: "+ahmetYas);
//Console.Write("zeynep yaş: "+zeynepYas);
//Console.Write("mehmet yaş: "+mehmetYas);
//Console.Write("ali yaş: "+aliYas);

//bool yasSonuc = ahmetYas > zeynepYas;//bu işlem bize hata verecektir. Çünkü değişkenleri tipi metinsel (string) olduğu için metinsel tiplerin büyük küçüklük gibi operatörler ile kullanımı mümkün değildir.


//console'dan bir kullanıcı adı alın ardından bir de şifre değeri alın. Bu kullanıcı adı "admin" ve şifre "1234" ise ekranda TRUE değeri eğer blgiler yanlış ise ekranda FALSE değerini gösterin.

string kullaniciad = "";
string sifre = "";

Console.Write("kullanıcı ad: ");
kullaniciad=Console.ReadLine().ToLower();//okunan değeri küçük harf ile aktarır.

Console.Write("şifre: ");
sifre=Console.ReadLine();

bool sonuc = kullaniciad == "admin" && sifre == "1234" ;

Console.WriteLine(sonuc);



Console.Read();//kod akışı bu noktaya geldiği zaman console penceresinin kapanmaması için tanımlıyoruz.






