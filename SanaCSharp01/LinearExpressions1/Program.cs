
using System.Xml;

namespace LinearExpressions01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            Console.Write("Enter value of a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter value of b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Enter value of c: ");
            c = double.Parse(Console.ReadLine());
            Console.Write("Enter value of d: ");
            d = double.Parse(Console.ReadLine());

            double x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - (a * a) / (b * b);
            Console.WriteLine($"x={x}");
            double y = 10 * (a + b) * (c - d) / c + d * d * (a * a - b * b) / (b - a);
            Console.WriteLine($"y={y}");
            double z = (Math.Pow(x * x - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) / (5 * a + 3 * b);
            Console.WriteLine($"z={z}");
            double r = (0.5 * a + (3 / 4.0) * b - 7 / 5.0) / (3 * c + 1) + 1 / (a - c);
            Console.WriteLine($"r={r}");

        }
    }
}