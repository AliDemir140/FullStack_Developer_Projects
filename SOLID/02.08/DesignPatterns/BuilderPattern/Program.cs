
using BuilderPattern.Concretes;
using BuilderPattern.Directors;

var gamePc = new GameComputer();
var officePc = new OfficeComputer();

var director = new Director();

director.Construct(gamePc);
director.Construct(officePc);

Console.WriteLine(gamePc.GetComputer());
Console.WriteLine(officePc.GetComputer());
Console.Read();




