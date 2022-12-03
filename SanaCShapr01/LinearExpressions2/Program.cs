double z1, z2, m, n, y, a, b, x;

Console.Write("Input m: ");
m = double.Parse(Console.ReadLine());
Console.Write("Input n: ");
n = double.Parse(Console.ReadLine());

z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt((Math.Pow(m, 3) * n)) + n * m + Math.Pow(m, 2) - m);

z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;

Console.WriteLine("Results: z1 = {0}; z2 = {1};", z1, z2);

Console.Write("Input a: ");
a = double.Parse(Console.ReadLine());
Console.Write("Input b: ");
b = double.Parse(Console.ReadLine());
Console.Write("Input x: ");
x = double.Parse(Console.ReadLine());

y = 2.4 * Math.Abs(((Math.Pow(x, 2) + b) / a)) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);

Console.WriteLine("Result: y = {0}", y);
