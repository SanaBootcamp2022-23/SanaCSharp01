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

z1 = (((m - 1) * Math.Sqrt(m)) - ((n - 1) * Math.Sqrt(n))) / (Math.Sqrt(Math.Pow(m, 3) * n) + (n * m) + Math.Pow(m, 2) - m);
z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
Console.WriteLine($"Відповідь z1 = {z1}, z2 = {z2}");

