while (true)
{
    double m, n;

    Console.Write("Enter n -> ");
    if (!double.TryParse(Console.ReadLine(), out n))
    {
        Console.WriteLine("Incorrect value");
        continue;
    }

    Console.Write("Enter m -> ");
    if (!double.TryParse(Console.ReadLine(), out m))
    {
        Console.WriteLine("Incorrect value");
        continue;
    }


    if (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + m * m - m != 0)
    {
        double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n))/(Math.Sqrt(Math.Pow(m, 3) * n) + n * m + m * m - m);
        Console.WriteLine("z1 = " + z1);
    }
    else
    {
        Console.WriteLine("z1 = error: division by zero");
    }

    if (m != 0)
    {
        double z2 = (Math.Sqrt(m) - Math.Sqrt(n))/m;
        Console.WriteLine("z2 = " + z2);
    }
    else
    {
        Console.WriteLine("z2 = error: division by zero");
    }
    Console.WriteLine("\n");


    double x, a, b;

    Console.Write("Enter x -> ");
    if (!double.TryParse(Console.ReadLine(), out x))
    {
        Console.WriteLine("Incorrect value");
        continue;
    }

    Console.Write("Enter a -> ");
    if (!double.TryParse(Console.ReadLine(), out a))
    {
        Console.WriteLine("Incorrect value");
        continue;
    }

    Console.Write("Enter b -> ");
    if (!double.TryParse(Console.ReadLine(), out b))
    {
        Console.WriteLine("Incorrect value");
        continue;
    }


    if (a != 0)
    {
        double y = 2.4f * Math.Abs((x * x + b)/a) + (a - b) * (Math.Pow(Math.Sin(a - b), 2)) + (1/100) * (x - b);
        Console.WriteLine("y = " + y);
    }
    else
    {
        Console.WriteLine("y = error: division by zero");
    }

    Console.WriteLine("\n");
}
