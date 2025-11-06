using System.Data;
using System.Data.SqlClient;


//Connected Mimari
string connectionString = "Server=DESKTOP-J4PTH70;Database=Northwind;User Id=sa;Password=123;TrustServerCertificate=True;";

SqlConnection connection = new SqlConnection(connectionString);



SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from orders", connection);

DataTable dt = new DataTable();
//fill
sqlDataAdapter.Fill(dt);

foreach (DataRow dr in dt.Rows)
{
    foreach (object row in dr.ItemArray)
    {
        Console.WriteLine(row);
    }
}