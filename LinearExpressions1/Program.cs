class Program
{
    static void Main(string[] args)
    {

        Console.Write("а = ");

        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("b = ");

        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("c = ");

        double c = Convert.ToDouble(Console.ReadLine());

        Console.Write("d = ");

        double d = double.Parse(Console.ReadLine());

        double x = ((a + (2 * b) - c + d) / (c * d)) + ((a + b) / (c - d)) - (Math.Pow(a, 2) / Math.Pow(b, 2));

        double y = (((5 * (a + b) * (c - d)) / (0.5 * c))) + Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2) / (b - a)));

        double z = (Math.Pow(Math.Pow(x, 2) - (2 * x), 3) - (4 * ((Math.Pow(x, 4) + 1) * (1 - b))) / ((5 * a) + 3 * b));

        double r = (((0.5 * a) + (0.75 * b) - 1.4) / ((3 * c) + 1)) + (1 / (a - c));

        Console.Write("Розрахунок виразів:");

        Console.Write("\nx = " + x);

        Console.Write("\ny = " + y);

        Console.Write("\nz = " + z);

        Console.Write("\nr = " + r);

    }
}

