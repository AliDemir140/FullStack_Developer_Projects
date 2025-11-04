

//Random class: C# programlama dilinde rastge bir sayı oluşturmamıza olanak sağlayan nesnedir. Ancak özünde rastgele diye bir şey yoktur. öncesinde bu sayı bellidir ancak biz göremeyiz. Random bu sayıyı Pc'nin o anki işlemci yükü, ram kapasitesi, tarihi, saati, saniyesini baz alarak hesaplayıp bize rastgele olarak sonucu teslim eder.


//instance: bir nesnenin örneğini ram üzerine çıkartmaktır.

//Random rnd= new Random();




//1. Oyuncu için bir ad alın.
//2. Oyuncu için ad alın.

//1. oyuncunun zarını oluşturun ?????
//2. oyuncunun zarını oluşturun ?????

//1. oyuncu zar atar
//2. oyuncu zar atar

//sonuç belirlenir.
//console'a yazılır.


string oyuncuBir = "";
string oyuncuIki = "";
int zar1 = 0;
int zar2 = 0; 
Random rnd=new Random();

Console.WriteLine("1. oyuncu ad: ");
oyuncuBir = Console.ReadLine();

Console.WriteLine("2. oyuncu ad: ");
oyuncuIki=Console.ReadLine();

Console.WriteLine(oyuncuBir+" zar atması bekleniyor...");
Console.ReadLine();
zar1 = rnd.Next(1, 7);
Console.WriteLine(oyuncuBir+" attığı zar"+" "+zar1);

Console.WriteLine(oyuncuIki + " zar atması bekleniyor...");
Console.ReadLine();
zar2 = rnd.Next(1, 7);
Console.WriteLine(oyuncuIki + " attığı zar" + " " + zar2);

//Kazanma durumu
if (zar1 == zar2)
{
    Console.WriteLine("Oyun berabere!");
}
else if (zar1 < zar2)
{
    Console.WriteLine(oyuncuIki + " kazandı!");
}
else if(zar1>zar2)
{
    Console.WriteLine(oyuncuBir+" kazandı!");
}



