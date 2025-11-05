

using LSP_Validate.Abstracts;
using LSP_Validate.Concretes;

Rectangle rectangle = new Rectangle();
rectangle.Edge = 3;
rectangle.Height = 2;

double rectangleArea = rectangle.CalculateArea();

BaseShape sqaure = new Sqaure();
sqaure.Edge = 3;


double squareArea = sqaure.CalculateArea();

Console.WriteLine("Kare Alanı: "+squareArea);
Console.WriteLine("Dikdört Alanı: " + rectangleArea);

