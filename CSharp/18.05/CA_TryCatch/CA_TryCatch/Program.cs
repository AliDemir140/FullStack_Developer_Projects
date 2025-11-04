//Try Catch

/*
 Try ve Catch ayrı bloklar dahilinde tanımlanan ve birlikte kullanılan bir işlemdir. Bu işlem  TRY isimli blok içerisinde kodlar kontrol edilerek olası bir runtime hatası esnasında işlemi CATCH bloğuna aktarılmasını gerçekleştiririr. Böylelikle uygulama sonlandırılmaz bunun yerine kod akışı değiştirilir.


scope: kodların yaşam alanıdır.

 */



//try
//{ //scope başlangıç
//    Console.WriteLine("bir değer girin: ");
//    int gelenDeger = int.Parse(Console.ReadLine());

//    Console.WriteLine(gelenDeger);
//}//scope bitiş
//catch
//{
//    Console.WriteLine("bir hata meydana geldi!");
//}


//FormatException: Format hatası
//OverFlow Exception: Kapasite aşımı
//int gelenDeger = 0; //global alan
//try
//{ //scope başlangıç

//    //local alan
//    Console.WriteLine("bir değer girin: ");
//    gelenDeger = int.Parse(Console.ReadLine());


//    Console.WriteLine(gelenDeger);
//}//scope bitiş
//catch(FormatException ex)
//{
//    //Console.WriteLine(ex.Message);

//    Console.WriteLine("Format hatası alındı lütfen girilen değeri kontrol edin.");
//}
//catch(OverflowException ex)
//{
//    //Console.WriteLine(ex.Message);

//    Console.WriteLine(gelenDeger.GetType()+ " tip'in değeri aşıldı!");
//}
//catch
//{

//    Console.WriteLine("Genel bir hata meydana geldi.");
//}

//DivideByZeroException: bir sayının 0'a bölünme hatası.
//StackOverFlowException: sonuç döndürülmemesi.


try
{
    string stringDeger = "22";
    int intDeger = int.Parse(stringDeger);
    int divide = intDeger / 0;

    Console.WriteLine(intDeger);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}