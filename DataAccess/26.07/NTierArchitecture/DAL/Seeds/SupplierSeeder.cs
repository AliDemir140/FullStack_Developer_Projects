using DAL.Entities;

namespace DAL.Seeds
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
