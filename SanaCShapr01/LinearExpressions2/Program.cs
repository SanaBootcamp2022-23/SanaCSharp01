using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinearExpressions2
{
    class Programm
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            double a, b, m, n, z1, z2, y, x;

            Console.WriteLine("Введіть a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть m: ");
            m = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть n: ");
            n = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть x: ");
            x = double.Parse(Console.ReadLine());

            z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + m * m - m);
            z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);

            Console.WriteLine($"z1 = {z1} ");
            Console.WriteLine($"z2 = {z2} ");
            Console.WriteLine($"y = {y} ");
            

            Console.ReadKey();
        }
    }
}