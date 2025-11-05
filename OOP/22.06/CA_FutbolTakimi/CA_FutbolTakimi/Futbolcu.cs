namespace CA_FutbolTakimi
{
    public class Futbolcu//BaseClass
    {
        //bir futbolcunun ....'sı olur.
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string FormaNo { get; set; }

        public int SutGuc { get; set; }

        public string SutCek()
        {
            return $"{Ad} {SutGuc} Şut Çekti";
        }

    }
}
