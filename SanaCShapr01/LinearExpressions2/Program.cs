using System;

namespace LinearExpressions2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            double m, n, a, b, x;

            Console.WriteLine("Введіть m:");
            n = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть n:");
            m = double.Parse(Console.ReadLine());

            double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / ((Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m));
            double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;

            Console.WriteLine($"Вираз z1 = {z1}\nВираз z2 = {z2}\n");

            Console.WriteLine("Введіть a:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть b:");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть x:");
            x = double.Parse(Console.ReadLine());

            double y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);

            Console.WriteLine("y = {0}", y);
        }
    }
}
