namespace CA_Interface
{
    public abstract class Otomobil //Baseclass
    {
        //bir otomobilin ...'sı olur.

        /// <summary>
        /// Özellikler
        /// </summary>
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }


        ///Eylemler (Metotlar)
        ///
        //bir otomobil ... yapabilir.
        public abstract string MaxHiz();// ezilmesi zorunlu bir metot

    }
}
