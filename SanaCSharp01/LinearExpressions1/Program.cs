﻿class Program
{
    static void Main()
    {
        double a, b, c, d;
        double x, y, z, r;
        Console.Write("Enter a number a: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Enter a number b: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("Enter a number c: ");
        c = double.Parse(Console.ReadLine());
        Console.Write("Enter a number d: ");
        d = double.Parse(Console.ReadLine());
        x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - ((a * a) / (b * b));
        Console.WriteLine($"x = {x}");
        y = ((5 * (a + b) * (c - d))) / ((1d/2) * c) + (d * d) * (((a * a) - (b * b)) / (b - a));
        Console.WriteLine($"y = {y}");
        z = ((Math.Pow((x * x - 2 * x), 2) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / 5 * a + 3 * b;
        Console.WriteLine($"z = {z}");
        r = ((1d / 2 * a) + (3d / 4 * b) - (7d / 5)) / (3 * c + 1) + (1 / (a - c));
        Console.WriteLine($"r = {r}");
    }
}
