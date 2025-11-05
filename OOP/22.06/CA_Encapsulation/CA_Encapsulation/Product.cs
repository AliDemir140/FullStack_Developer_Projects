//CTRL+R+G=> kullanılmayan kütüphaneler kaldırılır.

namespace CA_Encapsulation
{
    public class Product
    {
        //Product isminde bir adet class oluşturun. İçerisinde aşağıdaki alanlar (field) barınsın.
        //Marka
        //Beden
        //Fiyat=> KDV Hariç
        //Renk
        //yukarıda tanımlı olan field'ları doldurarak 1 adet ürün oluşturun. Ancak bu ürünün fiyatı KDV hariç tanımlansın. Okuma esnasında KDV dahil okunsun.



        private decimal _fiyat;//KDV Hariç

        public decimal Fiyat
        {
            get
            {
                return _fiyat;
            }
            set
            {
                _fiyat = value;
            }
        }

        public decimal KdvDahilFiyat
        {
            //bu özellike sadee okunabilir olarak tanımlandı.
            get
            {
                return _fiyat * 1.20m;
            }

        }


        private string _beden;
        public string Beden
        {
            get
            {
                return _beden;
            }
            set
            {
                switch (value)
                {
                    case "S":
                    case "M":
                    case "L":
                    case "XL":
                        _beden = value;
                        break;

                    default:
                        _beden = null;
                        break;
                }
            }
        }



        //public string marka;
        public string Marka { get; set; }
        public string Kategori { get; set; }
        //snippet: kodların kısaltılmış versiyonları.
        public string Renk { get; set; }
       

    }
}
