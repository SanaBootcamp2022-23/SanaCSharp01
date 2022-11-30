using System;

namespace LinearExpressions2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter m:");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter n:");
            double n = double.Parse(Console.ReadLine());
            double z1 = ((m - 1) * Math.Sqrt(m)-(n-1)*Math.Sqrt(n))/(Math.Sqrt(Math.Pow(m, 3)*n)+m*n+m*m-m);
            Console.WriteLine($"z1:{z1}");
            double z2 = (Math.Sqrt(m)-Math.Sqrt(n))/m;
            Console.WriteLine($"z2:{z2}");
            double y = 2.4 * Math.Abs((x*x+b)/a)+(a-b)*Math.Sin(a-b)+Math.Pow(10,-2)*(x-b);
            Console.WriteLine($"y:{y}");

        }
    }
}
