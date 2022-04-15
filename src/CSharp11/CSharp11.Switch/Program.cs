using CSharp11.Switch;

Console.WriteLine("Hello, World!");
var array = new[] { 1, 2, 3, 4, 5, 6 };
var res = SpeedComp.MatchExp(array);
Console.WriteLine("result: " + res); //2+3+4=9

res = SpeedComp.MatchExp(new[] { 1, 2 });
Console.WriteLine("result: " + res); //2


res = SpeedComp.MatchExp(new[] { 1, 3, 2 });
Console.WriteLine("result: " + res); //2
