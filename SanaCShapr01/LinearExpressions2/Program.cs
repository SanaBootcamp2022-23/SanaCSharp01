Console.WriteLine("please input m:");
double m = double.Parse(Console.ReadLine());
Console.WriteLine("please input n:");
double n = double.Parse(Console.ReadLine());
Console.WriteLine("please input a:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("please input b:");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("please input x:");
double x = double.Parse(Console.ReadLine());

double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt((Math.Pow(m, 3) * n)) + m * n + m * m - m);
double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
double y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
Console.WriteLine($"result of _z1_ is: \n{z1}\n");
Console.WriteLine($"result of _z2_ is: \n{z2}\n");
Console.WriteLine($"result of _y_ is:  \n{y}\n");
