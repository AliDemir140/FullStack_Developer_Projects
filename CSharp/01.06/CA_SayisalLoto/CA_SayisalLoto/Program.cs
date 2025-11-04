/*
 --1 ile 49 (dahil) arasında 6 adet rastgele sayı oluşturun. Bu sayılar tekrar edilmesin. Bu sayılardan 6'şar adet oluşturulacak.


1-5 8  15  23 36 38
2-3 12  18  24 35 39
3-
4-
5-
6- 
 */

int[] sayilar = new int[6];
Random rnd=new Random(); //instance
string tercih = "";

do
{
    for (int i = 0; i < 6; i++)
    {
        int rastgele = rnd.Next(1, 50);
        sayilar[i] = rastgele;

        for (int z = 0; z < i; z++)
        {
            if (sayilar[z] == sayilar[i])
            {
                i--;
                continue;
            }
        }
    }
    foreach (int sayi in sayilar)
    {
        Console.WriteLine(sayi);
    }

    Console.WriteLine("devam etmek istiyor musun? (e)");
    tercih = Console.ReadLine();

} while (tercih == "e");