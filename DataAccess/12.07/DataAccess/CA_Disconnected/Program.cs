//Kütüphane Nuget package manager üzerinden eklememiz gerekmektedir.
//System.Data
using System.Data;
//System.Data.SqlClient
using System.Data.SqlClient;

#region Disconnected
//Disconnected Mimari

//Eğer elimizde bulunan bir veritabanı içerisinden herhangi bir veriyi okumak istiyorsak bu işlemi disconnected mimari ile gerçekleştirebiliriz. Ancak bu işlem için öncesinde veritabanı bağlantısının açık olup olmadığını kontrol etmemiz gerekmektedir.

//Bağlantı adresi: (connectionstrings)
//https://www.connectionstrings.com/


//Mixed Authentication
/*
 Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPasswordTrustServerCertificate=True;
 */


//Windwod Auth
/*
 Server=myServerAddress;Database=myDataBase;Trusted_Connection=TrueTrustServerCertificate=True;;
 */


string connectionString = "Server=DESKTOP-J4PTH70;Database=Northwind;User Id=sa;Password=123;TrustServerCertificate=True;";

string query = "select * from Orders";

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
#endregion

