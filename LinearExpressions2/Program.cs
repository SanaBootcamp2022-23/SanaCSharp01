using System;

class Program {
  public static void Main (string[] args) {
    double a, b, x, m, n, y, z1, z2;

Console.WriteLine("Enter the value of m");
Console.Write("-> ");
m = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the value of n");
Console.Write("-> ");
n = double.Parse(Console.ReadLine());

z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;

Console.WriteLine("the value of z1" + z1);
Console.WriteLine("the value of z2"+z2);


Console.WriteLine("Enter the value of a");
Console.Write("-> ");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the value of b: ");
Console.Write("-> ");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the value of x: ");
Console.Write("-> ");
x = double.Parse(Console.ReadLine());

y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);

Console.WriteLine("the value of y: " + y);

  }
}