using CA_ServicePattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ServicePattern.Seeds
{
    public class SupplierSeeder
    {
        public static List<Supplier> Suppliers = new List<Supplier>
        {
            new Supplier{ID=1,CompanyName="ABC Lojistik"},
            new Supplier{ID=2,CompanyName="Tavuk Lojistik"},

        };
    }
}
