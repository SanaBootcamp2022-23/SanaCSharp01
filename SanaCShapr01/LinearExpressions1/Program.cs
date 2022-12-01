Console.Write("Please, input a:\n");
double a = double.Parse(Console.ReadLine());
Console.Write("Please, input b:\n");
double b = double.Parse(Console.ReadLine());
Console.Write("Please, input c:\n");
double c = double.Parse(Console.ReadLine());
Console.Write("Please, input d:\n");
double d = double.Parse(Console.ReadLine());

double x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - ((a * a) / (b * b));
Console.WriteLine($"x={x}");

double y = ((5 * (a + b) * (c - d)) / (c / 2)) + ((d * d * ((a * a - b * b) / (b - a))));
Console.WriteLine($"y={y}");

double z = ((Math.Pow((x * x - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / (5 * a + 3 * b);
Console.WriteLine($"z={z}");

double r = (((a / 2) + ((3 * b) / 4) - (7 / 5)) / (3 * c + 1)) + (1 / (a - c));
Console.WriteLine($"r={r}");