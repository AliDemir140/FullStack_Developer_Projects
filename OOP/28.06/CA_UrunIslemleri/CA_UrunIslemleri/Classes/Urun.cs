using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_UrunIslemleri.Classes
{
    internal class Urun//Base Class
    {
        //Özellikler
        private decimal _fiyat;
        public decimal Fiyat
        {
            get
            {
                return _fiyat;
            } 
            set
            {
                _kdvDAhil = value * 1.20m;
                _fiyat = value;
            }
        } //KDV Hariç

        private decimal _kdvDAhil;
        public decimal KdvDahilFiyat
        {
            get
            {
                return _kdvDAhil;

            }
        }

        //Metotlar
        public virtual void IndirimUygula()
        {
            
        }
    }
}
