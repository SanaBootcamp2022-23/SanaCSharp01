using System;

namespace LinearExpressions1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter c:");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter d:");
            double d = double.Parse(Console.ReadLine());

            double x = ((a+2*b-c+d)/(c*d))+((a+b)/(c-d))-((a*a)/(b*b));
            Console.WriteLine($"x:{x}");
            double y = ((5*(a+b)*(c-d))/(0.5*c))+(d*d)*(((a*a)-(b*b))/(b-a));
            Console.WriteLine($"y:{y}");
            double z = ((Math.Pow((x*x-2*x),3)-4*(Math.Pow(x,4)+1))*(1-b))/(5*a+3*b);
            Console.WriteLine($"z:{z}");
            double r = ((0.5*a+(3/4)*b-(7/5))/(3*c+1))+(1/(a-c));
            Console.WriteLine($"r:{r}");
        }
    }
}
