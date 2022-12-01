using System;
using System.Text;

namespace LinearExpressions1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            double a, b, c, d;
            double x, y, z, r;
            Console.WriteLine("Введіть значення a ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення b ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення c ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення d ");
            d = double.Parse(Console.ReadLine());

            x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - (Math.Pow(a, 2) / Math.Pow(b, 2));
            y = (5*(a+b)*(c-d))/((1.0/2)*c) + Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a));
            z = (Math.Pow(Math.Pow(x, 2) - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) / (5 * a + 3 * b);
            r = (1.0 / 2 * a + 3.0 / 4 * b - 7.0 / 5) / (3 * c + 1) + 1.0 / (a - c);

            Console.WriteLine($"x = {x}\ny = {y}\nz = {z}\nr = {r}");
        }
    }
}