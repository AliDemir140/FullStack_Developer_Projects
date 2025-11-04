//Kullanıcıdan 2 adet değer alın. Bu iki adet değerin toplamını, farkını, çarpımını, bölümü, mod console'da gösterin.

//Örnek Format: Toplam: 10
//              Fark: 5
//              Bölme: 2
//              Çarpım: 5
//              Mod: 1

//kullanıcı runtime'da hata almamalı. Eğer hata alınırsa kullanıcı Türkçe olarak bilgilendirilmeli.

//Eğer sıfıra bölünmeye çalışırsa "değer sıfıra bölünemez"
//Eğer ilgili tip int ise ve kullanıcı int'ın değer aralığının üstüne çıkmış ise "-2milyar ile 2 milyar arasında değer girişi yapın"
//Bunların haricinde ise "bir hata meydana geldi" 


//Global Alan
int intSayiBir = 0;
int intSayiIki = 0;

string gelenSayiBir = "";
string gelenSayiIki = null;

//int toplam = 0;
//int fark = 0;
//int carpin = 0;
//int bolme = 0;
int toplam, fark, carpim, bolme,mod = 0;


try
{
    Console.WriteLine("Sayı 1: ");
    gelenSayiBir = Console.ReadLine();

    Console.WriteLine("Sayı 2: ");
    gelenSayiIki = Console.ReadLine();

    intSayiBir = int.Parse(gelenSayiBir);
    intSayiIki = Convert.ToInt32(gelenSayiIki);

    //Toplama
    toplam = intSayiBir + intSayiIki;
    //Çıkarma
    fark= intSayiBir - intSayiIki;
    //Çarpma
    carpim= intSayiBir * intSayiIki;
    //Bölme
    bolme= intSayiBir / intSayiIki;
    //Mod
    mod = intSayiBir % intSayiIki;

    Console.WriteLine("Toplam: "+toplam);
    Console.WriteLine("Fark: "+fark);
    Console.WriteLine("Çarpım: "+carpim);
    Console.WriteLine("Bölme: "+bolme);
    Console.WriteLine("Mod: "+mod);


}
catch (DivideByZeroException)
{
    Console.WriteLine("Değer 0'a bölünemez!"+intSayiBir+" "+intSayiIki);
}
catch (OverflowException)
{
    string intMax = int.MaxValue.ToString();
    string intMin=int.MinValue.ToString();
    Console.WriteLine("Girilen değer "+intMin+" ile "+intMax+" aralığıdında olmalıdır.");
}
catch (FormatException)
{
    Console.WriteLine("girilen değer sayısal formatta değil.");
}
catch
{
    Console.WriteLine("bir hata meydana geldi!");
}