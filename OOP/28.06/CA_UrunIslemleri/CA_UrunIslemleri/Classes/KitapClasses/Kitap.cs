namespace CA_UrunIslemleri.Classes.KitapClasses
{
    internal class Kitap : Urun
    {
        public string Ad { get; set; }
        public string YazarAdSoyad { get; set; }
        public int SayfaSayisi { get; set; }
        public string Yayinevi { get; set; }

        public override void IndirimUygula()
        {
            //%10 indirim uygulandı.

            Fiyat = Fiyat * 0.90m;
        }

    }
}
