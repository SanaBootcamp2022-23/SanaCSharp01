Console.WriteLine("a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("c: ");
double c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("d: ");
double d = Convert.ToDouble(Console.ReadLine());

double x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - ((a * a) / (b * b));

double y = ((5 * (a + b) * (c - d)) / (c / 2)) + ((d * d * (a * a - b * b)) / (b - a));

double z = (Math.Pow(x * x - 2 * x, 3) - 4 * (x * x * x * x + 1) * (1 - b)) / (5 * a + 3 * b);

double r = (a / 2 + 3 * b / 4.0 - 1.4) / (3 * c + 1) + (1 / (a - c));

Console.WriteLine("---Results---");
Console.WriteLine("x: " + x);
Console.WriteLine("y: " + y);
Console.WriteLine("z: " + z);
Console.WriteLine("r: " + r);