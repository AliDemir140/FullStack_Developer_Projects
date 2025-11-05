using SingletonPattern.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Models.Context
{
    public class ProjectContext
    {

        //todo: burada veritabanında bulunan tabloyu temsil eden bir metot/özellik oluşturulacak.

        private ProductData _instance;

        public ProductData ProductData { 
            get 
            {

                if (_instance == null)
                {
                    _instance = new ProductData();
                }
                return _instance;



            } 
        }

    }
}
