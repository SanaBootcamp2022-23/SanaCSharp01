
while (true)
{
    double a, b, c, d;

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

    Console.Write("Enter c -> ");
    if (!double.TryParse(Console.ReadLine(), out c))
    {
        Console.WriteLine("Incorrect value");
        continue;
    }

    Console.Write("Enter d -> ");
    if (!double.TryParse(Console.ReadLine(), out d))
    {
        Console.WriteLine("Incorrect value");
        continue;
    }

    double x = 0;
    bool xExists = false;
    if (!(c * d == 0 || c - d == 0 || b == 0))
    {
        x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - (a * a) / (b * b);
        Console.WriteLine("x = " + x);
        xExists = true;
    }
    else
    {
        Console.WriteLine("x = error: division by zero");
    }

    if (!(0.5f * c == 0 || b - a == 0))
    {
        double y = (5 * (a + b) * (c - d)) / (0.5f * c) + ((d * d) * (a * a - b * b)) / (b - a);
        Console.WriteLine("y = " + y);
    }
    else
    {
        Console.WriteLine("y = error: division by zero");
    }

    if (!(!xExists || 5 * a + 3 * b == 0))
    {
        double z = ((Math.Pow((x * x - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / (5 * a + 3 * b);
        Console.WriteLine("z = " + z);
    }
    else
    {
        Console.WriteLine("z = error: division by zero or x doesn`t exist");
    }

    if (!(3 * c + 1 == 0 || a - c == 0))
    {
        double r = ((1f / 2) * a + (3f / 4) * b - (7f / 5)) / (3 * c + 1) + 1 / (a - c);
        Console.WriteLine("r = " + r);
    }
    else
    {
        Console.WriteLine("r = error: division by zero");
    }
    Console.WriteLine("\n");
}
