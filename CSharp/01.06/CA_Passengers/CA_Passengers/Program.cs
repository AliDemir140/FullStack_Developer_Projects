#region Faz 1
//Öğrenciler
//Hakan, Sedat, Arda, Kenan, Ali, Muhammet, Yiğit, Berkay
//Ülkeler
//Danimarka, Fransa, Kanada, Almanya, İtalya,İspanya, Brezilya,Arjantin 
#endregion


#region Faz 2
//Uygulama çalıştığında kullanıcıdan bir onay alınsın. Onay alındıktan sonra ilk öğrenciye rastgele bir ülkeyi dahil edecek. (Aşağıdaki formatta olduğu gibi)

//Öğrenci: Hakan, Ülke: Danimarka Yolculuk Tarihi: (1 yıl içerisinde herhangi bir zamanda gün/ay/yıl saat)


#region Tarih işlemleri
//DateTime now = DateTime.Now;

//int day = DateTime.Now.Day;
//int month = DateTime.Now.Month;
//int year = DateTime.Now.Year;
//int hour = DateTime.Now.Hour;

//DateTime ileriTarih = new DateTime(2100, 01, 01);

//Console.WriteLine(ileriTarih); 
#endregion
#endregion

string[] students = { "Hakan", "Sedat", "Arda", "Kenan", "Ali", "Muhammet", "Yiğit", "Berkay" };

string[] countries = { "Danimarka", "Fransa", "Kanada", "Almanya", "İtalya", "İspanya", "Brezilya", "Arjantin" };

string[] passengers = new string[students.Length];

Console.WriteLine("yolcu listesi için işlemi onaylıyor musunuz? (e)");
string gelenDeger = Console.ReadLine();

if (gelenDeger == "e")
{
    Random rnd = new Random();


    for (int i = 0; i < students.Length; i++)
    {
        int rastgele = rnd.Next(0, students.Length);
        string country = countries[rastgele];
        int randomDay = rnd.Next(1, 366);

        DateTime date = DateTime.Now.AddDays(randomDay);

        string passenger = $"Yolcu: {students[i]} Ülke: {country} Tarih: {date}";
        passengers[i] = passenger;
    }

    //Eğer belirli bir öğrenci yolcu listelesine alınmayacaksa continue ile devam edilmesini sağlyabiliriz.
    //for (int i = 0; i < students.Length; i++)
    // {
    //     if (students[i] == "Sedat")
    //     {
    //         continue;
    //     }
    //     else
    //     {
    //         int rastgele = rnd.Next(0, students.Length);
    //         string country = countries[rastgele];
    //         int randomDay = rnd.Next(1, 366);

    //         DateTime date = DateTime.Now.AddDays(randomDay);

    //         string passenger = $"Yolcu: {students[i]} Ülke: {country} Tarih: {date}";
    //         passengers[i] = passenger;
    //     }
    // }

    foreach (string p in passengers)
    {
        Console.WriteLine(p);
    }

}

