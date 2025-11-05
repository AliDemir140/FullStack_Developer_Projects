//Kahve sipariş uygulaması

using OCP_Bad;



//Latte 2 adet
decimal toplamTutar = Coffee.GetTotalPrice(2, CoffeeType.Mocha);

Console.WriteLine(toplamTutar);