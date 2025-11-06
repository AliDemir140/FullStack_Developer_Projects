using CA_NorthwindEF.Managers.Abstracts;
using CA_NorthwindEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_NorthwindEF.Managers.Concretes
{
    internal class SupplierManager : ISupplierManager
    {

        NorthwindContext context = new NorthwindContext();


        public string CreateSupplier(Supplier supplier)
        {
            try
            {
                context.Suppliers.Add(supplier);
                context.SaveChanges();
                return $"{supplier.CompanyName} tedarikçi olarak eklendi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
