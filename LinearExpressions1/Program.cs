

internal class Program
{
    private static void Main(string[] args)
    {
        double a, b, c, d;
        double x, y, z, r;
        Console.Write("A ");
        a = double.Parse(Console.ReadLine());
        Console.Write("B ");
        b = double.Parse(Console.ReadLine());
        Console.Write("C ");
        c = double.Parse(Console.ReadLine());
        Console.Write("D ");
        d = double.Parse(Console.ReadLine());
        if (a != 0 && b != 0 && c != 0 && d != 0)
        {
            x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - a * a / (b * b);
            Console.WriteLine($"X :{x}");
            y = 5 * (a + b) * (c - d) / (0.5 * c) + d * d * (a * a - b * b) / (b - a);
            Console.WriteLine($"Y :{y}");
            z = (Math.Pow((x * x) - (2 * x), 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) / (5 * a + 3 * b);
            Console.WriteLine($"Z :{z}");
            r = ((0.5 * a) + (0.75 * b) - (7 / 5)) / (3 * c + 1) + (1 / (a - c));
            Console.WriteLine($"R :{r}");
        }
        else
        {
            Console.WriteLine("Error! Number = 0");
        }
    }
}