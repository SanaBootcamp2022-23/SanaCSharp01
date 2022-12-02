
double m, n, z1, z2,rez1,rez2;
Console.WriteLine("Введіть m");
m = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введіть n");
n = Convert.ToDouble(Console.ReadLine());
z1 = ((m - 1) * Math.Sqrt(m)) - ((n - 1) * Math.Sqrt(n));
z2 = Math.Sqrt(Math.Pow(m, 3)) * n + (m * n) + ((m * m) - m);
rez1 = z1 / z2;
Console.WriteLine("z1="+rez1);
rez2 = (Math.Sqrt(m)) - Math.Sqrt(n) / m;
Console.WriteLine("z2="+rez2);
double a, b, x, y, y1, y2, y3;
Console.WriteLine("Введіть x");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введіть a");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введіть b");
b = Convert.ToDouble(Console.ReadLine());
y1 = 2.4 * Math.Abs((x * x + n) / a);
y2 = (a - b) * Math.Pow(Math.Sin(a - b), 2);
y3 = Math.Pow(10, -2) * (x - b);
y = y1 + y2 + y3;
Console.WriteLine("y="+y);













