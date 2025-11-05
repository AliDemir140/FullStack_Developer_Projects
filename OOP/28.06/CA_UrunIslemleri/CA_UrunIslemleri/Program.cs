//Class
/*Urun => Fiyat
 //Kitap
	--Edebiyat
	--Roman
//Elektronik
	--Cep Telefonu
	--OyunKonsol
//Müzik
	--YerliPlak
	--YabancıPlak
 */


using CA_UrunIslemleri.Classes.ElektronikClasses;
using CA_UrunIslemleri.Classes.KitapClasses;
using CA_UrunIslemleri.Classes.MuzikClasses;

#region Örnek İşlemler
//Roman roman = new Roman();
//roman.Fiyat = 100;
////roman.KdvDahilFiyat = 1000; burası readonly olduğu için değer atamaz. Atanmış olan değer okunur.

////Console.WriteLine(roman.Fiyat);

//roman.Fiyat = roman.IndirimUygula();



////Console.WriteLine($"KDV Hariç: {roman.Fiyat}");
////Console.WriteLine($"KDV Dahil: {roman.KdvDahilFiyat}");

//CepTelefonu cepTelefonu = new CepTelefonu();

//cepTelefonu.Marka = "IPhone";
//cepTelefonu.Fiyat = 90000;
//Console.WriteLine($"Cep Telefonu KDV Hariç: {cepTelefonu.Fiyat}");
//cepTelefonu.Fiyat = cepTelefonu.IndirimUygula();
//Console.WriteLine($"Cep Telefonu KDV Hariç: {cepTelefonu.KdvDahilFiyat}"); 
#endregion

List<Elektronik> elektronikUrunler = new List<Elektronik>();

List<Kitap> kitapUrunleri=new List<Kitap>();

List<Muzik> muzikUrunleri = new List<Muzik>();


//3 adet kitap
Roman roman = new Roman();
roman.Ad = "Satranç";
roman.Fiyat = 100;
kitapUrunleri.Add(roman);

Edebiyat edebiyat = new Edebiyat();
edebiyat.Ad = "Çalıkuşu";
edebiyat.Fiyat = 150;
kitapUrunleri.Add(edebiyat);


//5 adet telefon
CepTelefonu cepTelefonu=new CepTelefonu();
cepTelefonu.Marka = "Apple";
cepTelefonu.Model = "IPhone";
cepTelefonu.Fiyat = 90000;
elektronikUrunler.Add(cepTelefonu);

//2 adet oyun konsol
OyunKonsol oyunKonsol = new OyunKonsol();
oyunKonsol.Marka = "Plastation 5";
oyunKonsol.Fiyat = 50000;
elektronikUrunler.Add(oyunKonsol);

//1 adet yerli plak
YerliPlak yerliPlak = new YerliPlak();
yerliPlak.Ad = "Müsadenizle Çocuklar";
yerliPlak.Fiyat = 200;
muzikUrunleri.Add(yerliPlak);
//3 adet yabancı plak.

//Foreach
foreach (Elektronik elk in elektronikUrunler)
{
	elk.IndirimUygula();
    Console.WriteLine($"Marka: {elk.Marka} KDV DAhil (İndirimli): {elk.KdvDahilFiyat}");

}

foreach (Kitap ktp in kitapUrunleri)
{
	ktp.IndirimUygula();
    Console.WriteLine($"Kitap Ad: {ktp.Ad} KDV Dahil (İndirimli): {ktp.KdvDahilFiyat}");
}

foreach (Muzik mzk in muzikUrunleri)
{
	mzk.IndirimUygula();
    Console.WriteLine($"Plak Ad: {mzk.Ad} KDV Dahil (İndirimli): {mzk.KdvDahilFiyat}");
}