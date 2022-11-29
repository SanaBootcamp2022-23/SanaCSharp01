using System;

namespace LinearExpressions1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 4 numbers");
            double a, b, c, d, x, y, z, r;
            Console.WriteLine("Input a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Input b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Input c:");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Input d:");
            d = double.Parse(Console.ReadLine());

            Console.WriteLine("Linear expressions:");
            x = (((a + 2*b -c + d)/ (c*d)) + (a+b/c-d) - ( Math.Pow(a,2)/ Math.Pow(b, 2) ));
            y = (5 * (a + b) * (c + d) / (0.5 * c)) + (Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a)));
            z = (Math.Pow((Math.Pow(x, 2) - 2 * x), 3) - 4 * ((Math.Pow(x, 4) + 1) * (1 - b))) / (5 * a + 3 * b);
            r = ((0.5 * a + 0.75 * b - 1.4) / (3 * c + 1)) + (1 / (a - c));
            Console.WriteLine($"x={x:f3} y={y:f3} z={z:f3} r={r:f3}",x,y,z,r);
        }
    }
}