// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello! Enter value of variables");
Console.Write("Enter m: ");
double m = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter n: ");
double n = Convert.ToDouble(Console.ReadLine());

var z1 = ((m - 1)*Math.Sqrt(m) - (n - 1)*Math.Sqrt(n)) / Math.Sqrt(Math.Pow(m , 3) * n) + n * m + Math.Pow(m, 2) - m;
Console.WriteLine(z1);