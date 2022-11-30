using System;
using System.Xml;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter values: ");
            Console.Write("m: ");
            double m = int.Parse(Console.ReadLine());
            Console.Write("n: ");
            double n = int.Parse(Console.ReadLine());
            Console.Write("x: ");
            double x = int.Parse(Console.ReadLine());
            Console.Write("a: ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = int.Parse(Console.ReadLine());


            double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + m * m - m);
            Console.WriteLine($"z1: {z1}");

            double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            Console.WriteLine($"z2: {z2}");

            double y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + 0.01 * (x - b);
            Console.WriteLine($"y: {y}");

        }
    }
}