using BLL.Services.Abstracts;
using DAL.Entities.Concretes;
using DAL.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Concretes
{
    public class SupplierServiceManager : ServiceManager<Supplier>, ISupplierServiceManager
    {
        public SupplierServiceManager(IRepository<Supplier> repository) : base(repository)
        {
        }
        // Tedarikçi ile ilgili özel iş kuralları ve metotlar buraya eklenebilir
        //todo: aşağıdaki metot ServiceManager içerisinde zaten bulunduğu için tekrara düşmüş olacak.
        //public List<Supplier> GetActiveSuppliers()
        //{
        //    return GetActives().Where(s => s.IsActive).ToList();
        //}
    }
}
