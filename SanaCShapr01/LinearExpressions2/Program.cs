// See https://aka.ms/new-console-template for more information
using System;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number m:");
        double m = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter number n:");
        double n = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter number a:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter number b:");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter number x:");
        double x = Convert.ToDouble(Console.ReadLine());
        double z1;
        double z2;
        double y;

        z1 = (m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n) / Math.Pow(m, 3 * n) + (n * m) + (m * m) - m;

        z2 = Math.Sqrt(m) - Math.Sqrt(n) / m;



        Console.WriteLine($"z1 = {z1}; z2 = {z2}");


        y = 2.4 * ((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(1.0), 2) * (a - b) + Math.Pow(10, -2) * (x * b);

        Console.WriteLine($"y = {y}");

        Console.ReadKey();

    }
}
