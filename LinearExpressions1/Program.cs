internal class Program
{
    private static void Main(string[] args)
    {
        double a, b, c, d,
            x, y, z, r;

        Console.WriteLine("");
        a = ParseDoubleVar(nameof(a));
        b = ParseDoubleVar(nameof(b));
        c = ParseDoubleVar(nameof(c));
        d = ParseDoubleVar(nameof(d));

        x = X(a, b, c, d);
        y = Y(a, b, c, d);
        z = Z(a, b, x);
        r = R(a, b, c);

        Console.WriteLine($"\nResult:");
        Console.WriteLine($"\tx = {x:0.00}");
        Console.WriteLine($"\ty = {y:0.00}");
        Console.WriteLine($"\tz = {z:0.00}");
        Console.WriteLine($"\tr = {r:0.00}");
    }

    public static double ParseDoubleVar(string varName)
    {
        bool success;
        double result;

        do
        {
            Console.Write($"Insert value for {varName}: ");
            success = double.TryParse(Console.ReadLine(), out result);

            if (!success)
                Console.WriteLine("\nParsing error, try again");
        } while (!success);

        return result;
    }

    public static double X(double a, double b, double c, double d)
    {
        return (a + 2 * b - c + d) /
        (c * d) +
        (a + b) /
        (c - d) -
        Math.Pow(a, 2) /
        Math.Pow(b, 2);
    }

    public static double Y(double a, double b, double c, double d)
    {
        return (5 *
            (a + b) *
            (c - d) /
            (1.0 / 2 * c)) +
            Math.Pow(d, 2) *
            ((a * a - b * b) / (b - a));
    }

    public static double Z(double a, double b, double x)
    {
        return (Math.Pow(x * x - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1) * (1 - b)) /
               (5 * a + 3 * b);
    }

    public static double R(double a, double b, double c)
    {
        return (1.0 / 2 * a + 3.0 / 4 * b - 7.0 / 5) /
            (3 * c + 1) +
            1.0 /
            (a - c);
    }
}
