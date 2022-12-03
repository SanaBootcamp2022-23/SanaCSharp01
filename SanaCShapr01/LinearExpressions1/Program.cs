using System;

namespace LinearExpressions1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            double a, b, c, d;

            Console.WriteLine("Введіть а:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть b:");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть c:");
            c = double.Parse(Console.ReadLine()) ;

            Console.WriteLine("Введіть d:");
            d = double.Parse(Console.ReadLine());


            double x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - (Math.Pow(a, 2) / Math.Pow(b, 2));

            double y = (5 * (a + b) * (c - d)) / (1.0 / 2 * c) + Math.Pow(d, 2) * (Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a);

            double z = (Math.Pow((Math.Pow(x, 2) - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) / (5 * a + 3 * b);

            double r = (1.0 / 2 * a + 3.0 / 4 * b - 7.0 / 5) / (3 * c + 1) + 1 / (a - c);


            Console.WriteLine($" Вираз x = {x}\n Вираз y = {y}\n Вираз z = {z}\n Вираз r = {r}");
        }
    }
}
