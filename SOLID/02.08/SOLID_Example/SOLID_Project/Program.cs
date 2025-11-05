/*
 //Bir futbol takımı oluşturulacak. Bu işlem esnasında yıldız takımında bulunan bazı futbolcular as takıma transfer edilecek. Yıldız takımda bulunan oyuncuların listesi aşağıdaki gibidir;


List<YıldızTakım>

//Kaleci Arda
//Defans Kenan
//OrtaSaha Ali
//Forvet Recep

//List<AsTakım>
 */


using SOLID_Project.Abstracts;
using SOLID_Project.Concretes;

List<IFutbolcu> futbolcuAdaylar = new List<IFutbolcu>
{
    new Kaleci{Ad="Fatih", Soyad="Günalp",FormaNo="1"},
    new Defans{Ad="Arda",Soyad="Berktaş",FormaNo="2"}
};

List<Futbolcu> asTakim = new List<Futbolcu>();


foreach (IFutbolcu aday in futbolcuAdaylar)
{
    asTakim.Add(aday.Mevkii.Olustur(aday));
}

foreach (Futbolcu item in asTakim)
{
    if (item.IsDefans)
    {
        Console.WriteLine("Bu futbolcu yıldız takımdan as takıma Defans oyuncusu olarak eklendi!");
    }else if (item.IsKaleci)
    {
        Console.WriteLine("Bu futbolcu as takıma kaleci olarak eklendi!");
    }
}