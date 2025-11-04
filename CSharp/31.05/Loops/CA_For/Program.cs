//For

/*
 for döngüsü while döngüsü ile aynı mantığa sahip olsa da birbirlerinden ayrılan farklı özelliklere sahiptir. Bu fark ise while döngüsünde kullanılan iterasyon, koşul ve iterasyon artışı/azalış işlemleri for döngüsünde parametre olarak tanımlanır.


 */


//for(int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}


//a'dan z'ye alfabeyi console'da gösterin.


//char karakter = 'z';

//int intKarakter = karakter;

//Console.WriteLine(intKarakter);

//for(int i=97; i<=122; i++)
//{
//    char c=Convert.ToChar(i);
//    Console.WriteLine(c+" "+i);
//}


//NOT: Char arkaplanda int tutar char gösterir.
//for (char i = 'a'; i <= 'z'; i++)
//{
//    int ascii = i;
//    Console.WriteLine(i+" "+ascii);
//}

//console'da 1'den 10'a kadar çarpım tablosunu gösterin. For döngüsü kullanarak!

/*
    1x1=1
    1x2=2
    ..
    1x10=10
    ---------------------
    2x1=2
    2x2=4    
    2x10=20
    ------------------

    
 */

for(int i=1; i<=10; i++)
{
    for(int z=1; z<=10; z++)
    {
        string carpimTablosuFormat = $"{i}x{z}={i * z}";
        Console.WriteLine(carpimTablosuFormat);
    }
    Console.WriteLine("*********************");
}

//1'den 100'e kadar tek sayıların toplamı ile çift sayıların toplamının farklarının karesi nedir?

int ciftToplam = 0;
int tekToplam = 0;

for(int i=1; i<=100; i++)
{
    if (i % 2 == 0)//çift
    {
        ciftToplam += i;
    }
    else
    {
        tekToplam += i;
    }
}

int farkKare = (ciftToplam - tekToplam) * (ciftToplam - tekToplam);

Console.WriteLine(farkKare);

Console.Read();