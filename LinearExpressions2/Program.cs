// See https://aka.ms/new-console-template for more information
double z1, z2, m, n, x, b, a, y, t1,t2;

Console.Write("Input 'm' value: "); m = Convert.ToDouble((Console.ReadLine()));
Console.Write("Input 'n' value: "); n = Convert.ToDouble((Console.ReadLine()));
Console.Write("Input 'x' value: "); x = Convert.ToDouble((Console.ReadLine()));
Console.Write("Input 'b' value: "); b = Convert.ToDouble((Console.ReadLine()));
Console.Write("Input 'a' value: "); a = Convert.ToDouble((Console.ReadLine()));

z1 = (Math.Sqrt(m) * (m - 1) - Math.Sqrt(n) * (n - 1)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + m * m - m);
z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
y = 2.4 * Math.Abs((x * x + b) / a) + Math.Sin(a - b) * (a - b) + Math.Pow(10, -2) * (x - b);

Console.WriteLine("Z1 equals " + z1);
Console.WriteLine("Z2 equals " + z2);
Console.WriteLine("Y equals " + y);




