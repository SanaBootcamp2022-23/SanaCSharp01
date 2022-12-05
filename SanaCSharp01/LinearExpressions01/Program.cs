using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearExpressions01
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            double a, b, c, d , x, y, z, r;
            Console.WriteLine("Введіть a: "); a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть b: "); b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть c: "); c = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть d: "); d = double.Parse(Console.ReadLine());

            x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - (a * a) / (b * b);
            y = (5 * (a + b) * (c - d)) / (0.5 * c) + (d * d) * ((a * a - b * b) / (b - a));
            z = ((Math.Pow(x * x - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1) * (1 - b))) / (5 * a + 3 * b);
            r = (0.5 * a + 0.75 * b - 1.4) / (3 * c + 1) + 1 / (a - c);
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"z = {z}");
            Console.WriteLine($"r = {r}");

        }
    }
}
