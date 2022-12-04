Console.WriteLine("--- Вас вiтає програма обчислення чисел #2 ---");

double a, b, m, n, x;

Console.WriteLine("--- Дробовi числа вводити через кому <,> ---");

Console.Write("Введiть число а: ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введiть число b: ");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введiть число m: ");
m = Convert.ToDouble(Console.ReadLine());
Console.Write("Введiть число n: ");
n = Convert.ToDouble(Console.ReadLine());
Console.Write("Введiть число x: ");
x = Convert.ToDouble(Console.ReadLine());

double z1, z2, y;

z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(x)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);

z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;

y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);

Console.WriteLine("--- Число z1" + z1);
Console.WriteLine("--- Число z2:" + z2);
Console.WriteLine("--- Число y:" + y);