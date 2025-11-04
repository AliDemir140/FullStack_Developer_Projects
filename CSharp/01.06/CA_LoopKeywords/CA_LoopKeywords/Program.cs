//1-While
//2-Do While
//3-For
//4-Foreach

//Continue: bir döngü içerisinde işlemin doğrudan iterasyonu gönderilmesini istediğimiz durumlarda continue anahtar kelimesini kullanırız.
//5 adet 1 ile 10 arasında rastgele sayı oluşturun. Ancak oluşturulan bu  sayı 2 ise dahil edilmesin.

#region Continue
//Random rnd = new Random();
//string rastgeleSayilar = "";
//for (int i = 0; i < 5; i++)
//{

//    int number = rnd.Next(1, 11);
//    if (number == 2)
//    {
//        i--;
//        continue;
//    }
//    rastgeleSayilar += number + " ";
//}
//Console.WriteLine(rastgeleSayilar); 
#endregion



//Break: break anahtar kelimesi döngüyü sonlandırır.
//1 ile 100 arasında sayıları console'da gösterin. Ancak değer 50 olduğunda döngü sonlandırılsın.
#region Break
for (int j = 1; j < 5; j++)
{ //buradan devam eder.
    for (int i = 1; i <= 100; i++)
    {

        if (i == 50)
        {
            break;
        }
        Console.WriteLine(i);
    }

}
#endregion


//Return: Return anahtar kelimesi kullanıldığında bağlı bulunan scope {} yaşam alanı sonlandırır.

//değer 5 olduğunda bütün işlem sonlandırılsın ve yoluna devam etsin.
#region return
bool sart = true;

while (sart)
{

    for (int i = 1; i <= 100; i++)
    {
        if (i == 5)
        {
            return; //işlemi sonlandırmak istediğimizde
        }
        Console.WriteLine("döngü devam ediyor...");
    }
    Console.WriteLine("for döngüsü sonlandırıldı");
} 
#endregion
