//Disconnected

using CA_Performance.Models.Northwind;
using Microsoft.Data.SqlClient;
using System.Data;





//EF

namespace CA_Performance
{
    class Program
    {
        public static void Main(string[] args)
        {

            string connectionString = "Server=DESKTOP-J4PTH70;Database=Northwind;User Id=sa;Password=123;TrustServerCertificate=True;";
            string query = "select * from Orders";



            //Başlangıç
            DateTime baslangic = DateTime.Now;



            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand(query, connection);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open(); //bağlantı ğburada açılır.
            }

            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            connection.Close();//bağlantı burada kapatılır.

            foreach (DataRow dr in dt.Rows)
            {
                foreach (object row in dr.ItemArray)
                {
                    Console.WriteLine(row);
                }
            }

            //Bitiş
            DateTime bitis = DateTime.Now;

            //Bitiş-Başlangıc farkı (milisaniye)
            TimeSpan disconnectedIslemSonuc = bitis - baslangic;




            //Connected

            DateTime baslangic2 = DateTime.Now;


            SqlConnection connection2 = new SqlConnection(connectionString);



            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from orders", connection2);

            DataTable dt2 = new DataTable();
            //fill
            sqlDataAdapter.Fill(dt2);

            foreach (DataRow dr in dt2.Rows)
            {
                foreach (object row in dr.ItemArray)
                {
                    Console.WriteLine(row);
                }
            }

            DateTime bitis2 = DateTime.Now;
            TimeSpan connectedIslemSonuc = bitis2 - baslangic2;

           



            DateTime baslangic3 = DateTime.Now;
            NorthwindContext context = new NorthwindContext();

            foreach (var item in context.Categories)
            {
                Console.WriteLine(item.CategoryName);
            }
            //Disconnected
            Console.WriteLine("Disconnected Mimari İşlem Sonuç");
            Console.WriteLine(disconnectedIslemSonuc.Milliseconds);

            //Connected
            Console.WriteLine("Connected Mimari İşlem Sonuc");
            Console.WriteLine(connectedIslemSonuc.Milliseconds);

            //EntityFramework

            DateTime bitis3 = DateTime.Now;
            Console.WriteLine("EF işlem sonuç");
            Console.WriteLine((bitis3-baslangic3).Milliseconds);

        }
    }
}

/*
 Disconnected Mimari İşlem Sonuç
572
Connected Mimari İşlem Sonuc
947
EF işlem sonuç
909


Disconnected Mimari İşlem Sonuç
651
Connected Mimari İşlem Sonuc
967
EF işlem sonuç
689
 */