

namespace CA_Encapsulation
{
    internal class Otomobil
    {
        //MotorHacmi
        //Marka
        //Model
        //Renk
        //Sanziman


        //Müşteri sadece Mercedes marka otomobil satışı gerçekleştirdiği için kullanıcıdan alınan marka değeri kesinlikle "mercedes" eşit olması gerekmektedir. Aksi durumda marka değeri "tanımsız" olarak belirlensin.


        //Property=> Özellik
        private string _marka;
        public string Marka
        {
            //getter: getirici
            get
            {
                return _marka;
            }

            //setter: ayarlayıcı.
            set//dışarıdan gönderilen değeri tutar.
            {
                if (value == "mercedes")
                {
                    _marka = value;
                }
                else
                {
                    _marka = "tanımsız";
                }
            }
        }












        public double motorHacim;
        public string model;
        public string renk;
        public string sanziman;



    }
}
