using System;
namespace LinearExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.WriteLine("Введіть значення a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть значення b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть значення c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть значення d: ");
            double d = Convert.ToDouble(Console.ReadLine());
            double x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - (a * a) / (b * b);
            Console.WriteLine($"x = {x}");
            double y = (5 * (a + b) * (c - d)) / ((1.0 / 2) * c) + (d * d) * ((a * a - b * b) / (b - a));
            Console.WriteLine($"y = {y}");
            double z = ((Math.Pow((x * x - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / (5 * a + 3 * b);
            Console.WriteLine($"z = {z}");
            double r = ((1.0 / 2) * a + (3.0 / 4) * b - (7.0 / 5)) / (3 * c + 1) + 1 / (a - c);
            Console.WriteLine($"r = {r}");
        }
    }
}
