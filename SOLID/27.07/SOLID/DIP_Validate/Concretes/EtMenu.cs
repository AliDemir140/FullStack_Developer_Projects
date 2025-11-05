using DIP_Validate.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Validate.Concretes
{
    internal class EtMenu : IProduct
    {
        public string Tarif()
        {
            return "Etlerimiz dağlardan otlnana büyük baş hayvanların en nadide kesimlerinden elde edilerek pişirilir";
        }
    }
}
