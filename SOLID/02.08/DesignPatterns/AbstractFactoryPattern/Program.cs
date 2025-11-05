


using AbstractFactoryPattern.Abstracts;
using AbstractFactoryPattern.AssemblyLine;
using AbstractFactoryPattern.ConcreteFactories;

IAbstractCarFactory toyotaFactory = new ToyotaFactory();



var toyotaSeriUretim = new CarAssemblyLine(toyotaFactory);


IAbstractCarFactory mercedesFactory=new MercedesFactory();
var mercedesSeriUretim=new CarAssemblyLine(mercedesFactory);

toyotaSeriUretim.AssemblyCar();
mercedesSeriUretim.AssemblyCar();

Console.Read();


