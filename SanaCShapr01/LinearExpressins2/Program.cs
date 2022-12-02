double a, b, x, m, n, z1, z2, y;
Console.WriteLine("Введiть число а :");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введiть число b :");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введiть число m :");
m = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введiть число n :");
n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введiть число x :");
x = Convert.ToDouble(Console.ReadLine());
y = (2.4 * Math.Abs((Math.Pow(x, 2) + b) / a)) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
z1 = (((m - 1) * Math.Sqrt(m)) - ((n - 1) * Math.Sqrt(n))) / (Math.Sqrt(Math.Pow(m, 3) * n) + (n * m) + Math.Pow(m, 2) - m);
z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
Console.WriteLine($"Відповідь z1 = {Math.Round(z1, 2)}, z2 = {Math.Round(z2, 2)}, y = {Math.Round(y, 2)}");

