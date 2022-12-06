// See https://aka.ms/new-console-template for more information


double a, b, c, d;
Console.Write("a: ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("b: ");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("c: ");
c = Convert.ToDouble(Console.ReadLine());
Console.Write("d: ");
d = Convert.ToDouble(Console.ReadLine());

double x = (a + 2f * b - c + d) / (c * d) + (a + b) / (c - d) - (a * a) / (b * b);
double y = (5f * (a + b) * (c - d)) / ((1f / 2f) * c) + (d * d) * ((a * a) - (b * b) / (b - a));

double z1 = Math.Pow((x * x) - (2f * x), 3);
double z2 = 4f * (Math.Pow(x, 4) + 1f) * (1f - b);
double z3 = ((5f * a) + (3f * b));
double z = (z1 - z2) * (1f - b) / z3;

double r = (( ((1f / 2f) * a) + ((3f / 4f) * b) - (7f / 5f))) / (((3f * c) + 1f) + (1f / (a - c)));

Console.WriteLine("X: " + x.ToString());
Console.WriteLine("Y: " + y.ToString());
Console.WriteLine("Z: " + z.ToString());
Console.WriteLine("R: " + r.ToString());