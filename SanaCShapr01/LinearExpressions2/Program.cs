Console.Write("Задайте число m: ");
double m = Convert.ToDouble(Console.ReadLine());
Console.Write("Задайте число n: ");
double n = Convert.ToDouble(Console.ReadLine());
Console.Write("Задайте число x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Задайте число b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Задайте число a: ");
double a = Convert.ToDouble(Console.ReadLine());
double z1 = (((m - 1) * Math.Sqrt(m)) - ((n - 1) * Math.Sqrt(n))) /
            ((Math.Sqrt(Math.Pow(m, 3) * n) + n * m) + Math.Pow(m, 2) - m);
double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / (m);
double y = (2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) +
            Math.Pow(10, -2) * (x - 6));
Console.WriteLine("Число z1 = {0} \nЧисло z2 = {1} \nЧисло y = {2}", z1, z2, y);
