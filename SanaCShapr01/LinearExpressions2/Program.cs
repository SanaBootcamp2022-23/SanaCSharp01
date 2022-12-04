using System;

namespace linearExpressions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m, n;
            Console.WriteLine("Entyer the value of m: ");
            m = double.Parse(Console.ReadLine());
            Console.WriteLine("Entyer the value of n: ");
            n = double.Parse(Console.ReadLine());

            double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(m * m * m * n) + n * m * m * m - m);
            Console.WriteLine($"Z1 = {z1}");
            double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            Console.WriteLine($"Z2 = {z2}");

            double x, a, b;
            Console.WriteLine("Entyer the value of x: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Entyer the value of a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Entyer the value of b: ");
            b = double.Parse(Console.ReadLine());

            double y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + (x - b) / 100;
            Console.WriteLine($"Y = {y}");

        }
    }
}