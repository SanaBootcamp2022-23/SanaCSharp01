// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello! Enter value of variables");
Console.Write("Enter a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter c: ");
double c = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter d: ");
double d = Convert.ToDouble(Console.ReadLine());

var x = ((a + 2 * b - c + d) / c * d) + ((a + b) / (c - d)) - ((a * a) / (b * b));
Console.WriteLine(x);
var y = ((5 * (a + b) * (c - d)) / (1 / 2 * c)) + (d * d * (a * a - b * b)) / (b - a);
Console.WriteLine(y);
var z = ((Math.Pow((Math.Pow(x, 2) - 2 * x),3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / (5 * a + 3 * b);
Console.WriteLine(z);
var r = ((1 / 2 * a + 3 / 4 * b - 7 / 5) / 3 * c + 1) + 1 / a - c;
Console.WriteLine(r);