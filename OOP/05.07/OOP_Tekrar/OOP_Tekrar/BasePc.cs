using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tekrar
{
    public class BasePc : BaseClass
    {

        private string _marka;
        public string Marka
        {

            set
            {
                _marka= value+"-"+DateTime.Now.Year.ToString().Substring(2,2);

            }

            get
            {
                return _marka;
            }

        }
        public decimal Fiyat { get; set; }

        public virtual decimal Kampanya()
        {
            return Fiyat;
        }
    }
}
