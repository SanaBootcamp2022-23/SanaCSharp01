using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Enter m");
double m = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter n");
double n = Convert.ToDouble(Console.ReadLine());

double z_1 = ((m - 1) * Math.Pow(m, 1.0/ 2) - (n - 1) * Math.Pow(n, 1.0 / 2)) / (Math.Pow((m * m * m * n), 1.0 / 2) + n * m + m * m - m);
double z_2 = ((Math.Pow(m, 1.0 / 2) - Math.Pow(m, 1.0 / 2)) / m);


Console.WriteLine("z_1 = {0}", z_1);

Console.WriteLine("z_2 = {0}", z_2);


Console.WriteLine("Enter a");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter b");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter x");
double x = Convert.ToDouble(Console.ReadLine());

double y = 2.4 * Math.Abs((x * x + b) / (a)) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);


Console.WriteLine("y = {0}",y);

