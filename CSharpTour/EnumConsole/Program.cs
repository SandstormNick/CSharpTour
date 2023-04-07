using EnumConsole;

var turnip = SomeRootVegetable.Turnip;

var spring = Seasons.Spring;
var startingOnEquinox = Seasons.Spring | Seasons.Autumn;
var theYear = Seasons.All;

Console.WriteLine(turnip);
Console.WriteLine(spring);
Console.WriteLine(startingOnEquinox);
Console.WriteLine(theYear);