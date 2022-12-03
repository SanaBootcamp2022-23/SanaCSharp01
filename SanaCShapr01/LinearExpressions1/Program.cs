double a, b, c, d, x, y, z, r;

Console.Write("Input a: ");
a = double.Parse(Console.ReadLine());
Console.Write("Input b: ");
b = double.Parse(Console.ReadLine());
Console.Write("Input c: ");
c = double.Parse(Console.ReadLine());
Console.Write("Input d: ");
d = double.Parse(Console.ReadLine());

x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - (Math.Pow(a, 2) / Math.Pow(b, 2));

y = ((5 * (a + b) * (c - d)) / ((1 / 2.0) * c)) + Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)));

z = ((Math.Pow((Math.Pow(x, 2) - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / (5 * a + 3 * b);

r = ((1 / 2.0 * a + 3 / 4.0 * b - 7 / 5.0) / (3 * c + 1)) + (1 / (a - c));

Console.WriteLine("Results: x = {0}; y = {1}; z = {2}; r = {3}", x, y, z, r);