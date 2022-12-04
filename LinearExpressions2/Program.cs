double m, n, x, b, a, z1, z2, y;

Console.WriteLine("Enter m = ");
m = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter n = ");
n = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter x = ");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter a = ");
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter b = ");
b = Convert.ToDouble(Console.ReadLine());


z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(m * m * m * n) + n * m + m * m - m);
Console.WriteLine($"z1 = {z1}");

z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
Console.WriteLine($"z2 = {z2}");

y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + 0.01 * (x - b);
Console.WriteLine($"y = {y}");