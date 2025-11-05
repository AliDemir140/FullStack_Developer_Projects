//Boxing Unboxing

//object nesne = 5;//boxing

//int sayi =(int)nesne;//unboxing

//Console.WriteLine(sayi.GetType());

//Console.WriteLine(nesne.GetType());
//nesne = "elma";
//string metin = (string)nesne;

object[] nesneler = new object[3];
nesneler[0] = "elma";
nesneler[1] = 5;
nesneler[2] = true;



foreach (object obj in nesneler)
{
    if (obj is string)
    {
        string gelenString = (string)obj;
        Console.WriteLine(gelenString);
        
    }
    else if (obj is int)
    {
        int gelenInt = (int)obj;
        Console.WriteLine(gelenInt);
    }
    else if (obj is bool)
    {
        bool gelenBool = (bool)obj;
        Console.WriteLine(gelenBool);
    }
}


Console.Read();
