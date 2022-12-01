// See https://aka.ms/new-console-template for more information
using System;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number a:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter number b:");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter number c:");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter number d:");
        double d = Convert.ToDouble(Console.ReadLine());
        double x;
        double y;
        double z;
        double r;

        x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - a * a / (b * b);

        y = 5 * (a + b) * (c - d) / (0.5 * c) + d * d * (a * a - b * b) / (b - a);

        z = (Math.Pow(x * x - 2 * x, 3) - 4 * (x * x * x * x + 1)) * (1 - b) / (5 * a + 3 * b);

        r = (a / 2 + 3 * b / 4 - 7.0 / 5) / (3 * c + 1) + 1 / (a - c);

        Console.WriteLine($"x = {x}; y = {y}; z = {z}; r = {r}");

        Console.ReadKey();

    }
}