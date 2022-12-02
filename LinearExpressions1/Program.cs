using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaCSharp01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Console.WriteLine(" Обчислення виразів");
            double a, b, c, d;
            Console.Write(" Введіть значення змінної a:");
            a = double.Parse(Console.ReadLine());
            Console.Write(" Введіть значення змінної b:");
            b = double.Parse(Console.ReadLine());
            Console.Write(" Введіть значення змінної c:");
            c = double.Parse(Console.ReadLine());
            Console.Write(" Введіть значення змінної d:");
            d = double.Parse(Console.ReadLine());

            double x, y, z, r;
            x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - (a * a) / (b * b);
            y = (5 * (a + b) * (c - d)) / (1 / 2.0 * c) + d * d * ((a * a - b * b) / (b - a));
            z = ((Math.Pow(x * x - 2 * x, 3) - 4*((Math.Pow(x, 4) + 1) * (1 - b)))) / (5 * a + 3 * b);
            r = (1 / 2.0 * a + 3 / 4.0 * b - 7 / 5.0) / (3 * c + 1) + 1 / (a - c);

            Console.WriteLine($" x = {x}\n y = {y}\n z = {z}\n r = {r}");
        }
    }
}