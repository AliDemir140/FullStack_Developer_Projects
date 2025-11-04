//Types

//Primitive (ilkel) tipler: içerisinde tek bir değer tutan tiptir.
//byte
//sbyte
//short
//ushort
//int
//uint
//long
//ulong

try
{
    string metinselSayi = "111111111123a";

    //byte byteSayi = Convert.ToByte(metinselSayi); //değer aşımı hatası

    byte byteSayi = byte.Parse(metinselSayi);

    ushort ushortSayi = byteSayi;

    Console.WriteLine(ushortSayi);

    Console.Read();
}
catch(OverflowException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Kapasite aşıldı!");
}
catch (FormatException)
{
    Console.WriteLine("Format hatası");
}