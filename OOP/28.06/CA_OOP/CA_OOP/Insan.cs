namespace CA_OOP
{
    internal class Insan
    {
        //Bir insan'ın ....'sı olur.
        //Ad
        public string Ad { get; set; }
        //Soyad
        public string Soyad { get; set; }

        //Tam Ad
        public string TamAd
        {

            //sadece değerin okunmasını sağlar. "TamAd" özelliğine değer atanamaz. Çünkü set kısmı bulunmuyor.
            //get
            get
            {
                return Ad + " " + Soyad;
            }


        }
        //Tckn: tc kimlik numarasına gönderilen değer 11 karakter olmalı. eğer 11'in altında veya üzerinde ise değer atanmasın. Kullanıcıya console'da bir uyarı gösterilsin.


        private string _tckn;//burada 11 karakterden meydana gelen tckn tutulur.
        public string Tckn
        {
            get
            {
                return _tckn;
            }

            set
            {
                if (value.Length != 11)
                {
                    Console.WriteLine("lütfen 11 karakter değer girin!!");
                }
                else
                {
                    _tckn = value;
                }
            }
        }
        //Boy
        public double Boy { get; set; }
        //Kilo
        public double Kilo { get; set; }
        //Cinsiyet
        public bool Cinsiyet { get; set; }

        public string ornekDeger;//field
    }
}
