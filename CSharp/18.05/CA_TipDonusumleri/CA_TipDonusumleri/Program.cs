//Tip Dönüşümleri

/*
    veri tipleri arasında tip dönüşümlerini gerçekleştirmek için kullanılan ve bizim de ihtiyacımız olan bir class bulunmaktadır. Bu class "Convert" classıdır. Örnek vermek gerekirse C# programlama dilinde "123" string bir ifade olarak kullanır ancak aynı zamanda sayı olarak da kullanmak isteyebiliriz. 123 çift tırnak içerisinde değilse sayı olarak nitelendiriz.

    İmplicit Convert (Kapalı Dönüşüm)= dönüşüm işlemini C# kendisi otomatik gerçekleştirir. 

    Explicit Convert (Açık Dönüşüm)= dönüşüm işlemini bizzat yazılımcı gerçekleştirir. 


    Parse işlemi
    Parse işlemi doğrudan string olarak elde edilen tipler için kullanılır. Yani bir string tipi farklı bir tipe aktarmak istediğimizde kullanırız.

 */

//Kapalı Dönüşüm
byte sayi1 = 123;
int sayi2 = 123;
long sayi3 = sayi1;
sayi3=sayi2;

//Açık Dönüşüm
string sayi4 = "123";
int convertInt = Convert.ToInt32(sayi4);

#region Açık Dönüşüm Örnek Convert Class
//int toplam = convertInt + 10;

//Kullanıcıdan iki adet değer alın bu değerlerin toplamını console^'da gösterin.
//kullaıcıdan 1. sayı için değer alın.
//kullanıcıdan 2. sayı için değer alın.
//sayıları toplayın.
//toplamı ekranda yazdırın.

//Console.WriteLine("Sayı 1: ");
//int sayiBir = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Sayı 2: ");
//int sayiIki = Convert.ToInt32(Console.ReadLine());

//int toplam = sayiBir + sayiIki;

//Console.WriteLine(toplam); 
#endregion

#region Açık Dönüşüm Örnek Parse

string sayiBir = "123";
int sayiIki = 10;

int toplam = int.Parse(sayiBir) + sayiIki;
double toplamDouble = double.Parse(sayiBir)+sayiIki;
#endregion

//Kullanıcıdan bir vize değeri alın bir de final değeri alın. Vize'nin %30'nu final'in de %70'ni hesaplayarak kullanıcının notunu console'da gösterin.
//vize değeri için bir değişken oluştur
string vizeNot = "";
//final değeri için bir değişken oluştur.
string finalNot = "";
//kullanıcıdan vize değeri al.
Console.WriteLine("Vize: ");
vizeNot = Console.ReadLine();
//kullanıcıdan final değeri al.
Console.WriteLine("Final: ");
finalNot = Console.ReadLine();
//vize'nin %30'nu hesapla
double vize=double.Parse(vizeNot);//45
vize = vize * 0.30;
//final'in %70'ni hesapla
double final=Convert.ToDouble(finalNot);
final = final * 0.70;
//notu sonuc isimli değişkene aktar.
double sonuc = vize + final;
//notu ekranda göster.
Console.WriteLine("Sonuç: "+sonuc);