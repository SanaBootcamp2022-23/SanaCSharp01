double a, b, m, n, x, z1, z2, y;
Console.Write("m:");
m = Convert.ToDouble(Console.ReadLine());
Console.Write("n:");
n = Convert.ToDouble(Console.ReadLine());
Console.Write("x:");
x = Convert.ToDouble(Console.ReadLine());
Console.Write("a:");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("b:");
b = Convert.ToDouble(Console.ReadLine());
z1 = ((m - 1) * Double.Pow(m, 1 / 2) - (n - 1) * Double.Pow(n, 1 / 2)) /
     (Double.Pow(Double.Pow(m, 3), 1 / 2) + n * m + m * m - m);
Console.WriteLine($"z1 = {z1}");
z2 = (Double.Pow(m, 1/2)-Double.Pow(n, 1/2))/m;
Console.WriteLine($"z2 = {z2}");
y = 2.4 * Double.Abs((x * x + b) / a) + (a - b) * Double.Pow(Double.Sin(a - b), 2) + Double.Pow(10, -2) * (x - b);
Console.WriteLine($"y = {y}");
