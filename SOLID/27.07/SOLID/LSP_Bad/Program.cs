
using LSP_Bad;

Rectangle rectangle = new Rectangle();
rectangle.Width = 3;
rectangle.Height = 2;

double rectangleArea=CalculateArea.CalculateRectangleArea(rectangle);

Square square = new Square();
square.Height = 2;
square.Width = 3;



double squareArea =CalculateArea.CalculateSquareArea(square);

Console.WriteLine("Dikdörten Alanı: "+rectangleArea);
Console.WriteLine("Kare Alanı: "+squareArea);