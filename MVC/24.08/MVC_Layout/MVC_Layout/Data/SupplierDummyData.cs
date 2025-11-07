using MVC_Layout.Models;

namespace MVC_Layout.Data
{
    public class SupplierDummyData
    {

        public static List<Supplier> suppliers = new List<Supplier>
        {
            new Supplier{ID=1,CompanyName="Yılmaz Tic",ContactName="Ahmet Bodur",PhoneNumber="+90 212 237 26 26"},
            new Supplier{ID=2,CompanyName="Şahin Tic",ContactName="Şahin Kartal",PhoneNumber="+90 212 237 25 26"},
            new Supplier{ID=3,CompanyName="Kartal Tic",ContactName="Kartal Şahin",PhoneNumber="+90 212 237 26 26"}

        };
    }
}
