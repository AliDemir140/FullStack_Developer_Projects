namespace CA_UrunIslemleri.Classes.ElektronikClasses
{
    internal class Elektronik : Urun
    {
        public string Marka { get; set; }
        public string Model { get; set; }

        public override void IndirimUygula()
        {

            Fiyat = Fiyat * 0.95m;
        }

    }
}
