//ForEach: 
/*
 Foreach bir koleksiyon döngüsü olarak adlandırılır. Diğer döngülerden en büyük farkı iterasyon ve koşul barındırmaz!
 */

//string[] sehirler = { "İstanbul", "Ankara", "İzmir", "Bayburt", "Bilecik", "Sinop", "Kayseri", "Muş" };

//foreach (string sehir in sehirler )
//{
//    Console.WriteLine(sehir);
//}


//Uygulama çalıştığında console'da 5 adet öğrenci içinden rastgele bir öğrencinin adını gösterin.


//string[] students = new string[5];//instance

Random rnd = new Random();


string[] students = { "Hakan", "Arda", "Ali", "Muhammet", "Kenan" };
int rastgele = rnd.Next(0, students.Length);

Console.WriteLine(students[rastgele]);

Console.Read();