using DIP_Validate;
using DIP_Validate.Abstracts;
using DIP_Validate.Concretes;

List<IProduct> products=new List<IProduct>();

EtMenu etMenu=new EtMenu();
PizzaMenu pizza=new PizzaMenu();
TavukMenu tavuk=new TavukMenu();
BalikMenu balik=new BalikMenu();

products.Add(etMenu);
products.Add(pizza);
products.Add(tavuk);
products.Add(balik);

Restaurant restaurant = new Restaurant(products);

Console.WriteLine(restaurant.Tarifler());