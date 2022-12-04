double m, n;
Console.Write("Enter the value m: ");
m = double.Parse(Console.ReadLine());

Console.Write("Enter the value n: ");
n = double.Parse(Console.ReadLine());

Console.Write("\n");

double z1, z2;

z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / Math.Sqrt(Math.Pow(m, 3)) * n + n * m + (m * m) - m;
Console.Write("Example z1 = {0}\n", z1);

z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
Console.Write("Example z2 = {0}\n\n", z2);

double x, a, b, y;
Console.WriteLine("Enter the value x, a, b: \n");
Console.Write(" => "); x = double.Parse(Console.ReadLine());
Console.Write(" => "); a = double.Parse(Console.ReadLine());
Console.Write(" => "); b = double.Parse(Console.ReadLine());
Console.Write("\n");

y = 2.4 * Math.Abs((x * x) + b) / a + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
Console.Write("Example y = {0}\n\n", y);