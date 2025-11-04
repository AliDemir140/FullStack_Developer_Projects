#region Global Değişkenler
string[] manavReyonu = { "Domates", "Biber", "Patlıcan" };
decimal[] manavFiyatlar = { 50, 30, 40 };

string[] giyimReyonu = { "Ayakkabı", "Gömlek" };
decimal[] giyimFiyatlar = { 1000, 200 };

string[] sarkuteriReyonu = { "Peynir", "Zeytin" };
decimal[] sarkuteriFiyatlari = { 100, 150 };
string secim = "";

string[] sepet = new string[10];
int sepetIndex = 0;
#endregion




#region İşlem
while (true)
{
    Console.WriteLine("Merhaba Marketimize Hoşgeldiniz. Aşağıdan Menü seçin");
    Console.WriteLine("1. Manav");
    Console.WriteLine("2. Giyim");
    Console.WriteLine("3. Şarkuteri");
    Console.WriteLine("4. Sepet Görüntüle");
    Console.WriteLine("seçim:");
    secim=Console.ReadLine();

    switch (secim)
    {
        case "1":
            ReyonIslemleri(manavReyonu, manavFiyatlar);
            break;

        case "2":
            ReyonIslemleri(giyimReyonu,giyimFiyatlar);

            break;
        case "3":
            ReyonIslemleri(sarkuteriReyonu,sarkuteriFiyatlari);

            break;

        case "4":
            SepetGoruntle();
            break;

        default:
            Console.WriteLine("Geçersiz İşlem");
            break;
    }

}

#endregion

void ReyonIslemleri(string[] reyon, decimal[] fiyatlar)
{
    for (int i = 0; i < reyon.Length; i++)
    {
        Console.WriteLine(reyon[i]+" " + fiyatlar[i]);
    }
    Console.WriteLine("seçim: ");
    try
    {
        int seciliMenu = int.Parse(Console.ReadLine());
        Console.WriteLine("Adet: ");
        int adet=int.Parse(Console.ReadLine());


        string secilenUrun = $"({reyon[seciliMenu - 1] + " " + fiyatlar[seciliMenu - 1]})";
        secilenUrun += $"Adet: {adet} Toplam Tutar: {fiyatlar[seciliMenu - 1] * adet}";


        sepet[sepetIndex]= secilenUrun;
        sepetIndex++;
    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
    }
   
}



void SepetGoruntle()
{
    if (sepetIndex > 0)
    {
        foreach (string item in sepet)
        {
            Console.WriteLine(item);
        }
    }


    
}










