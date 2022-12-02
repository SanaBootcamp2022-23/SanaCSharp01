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
            double a, b, m, n, x;
            Console.Write(" Введіть значення змінної m:");
            m = double.Parse(Console.ReadLine());
            Console.Write(" Введіть значення змінної n:");
            n = double.Parse(Console.ReadLine());
            Console.Write(" Введіть значення змінної a:");
            a = double.Parse(Console.ReadLine());
            Console.Write(" Введіть значення змінної b:");
            b = double.Parse(Console.ReadLine());
            Console.Write(" Введіть значення змінної x:");
            x = double.Parse(Console.ReadLine());

            double z1, z2, y; //result

            z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + m * m - m);
            z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * (Math.Pow(Math.Sin(a - b), 2)) + Math.Pow(10, -2) * (x - b);
            
            Console.WriteLine($" \nz1 = {z1}\n z2 = {z2}\n y = {y}\n ");
        }
    }
}