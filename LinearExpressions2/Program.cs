internal class Program
{
    private static void Main(string[] args)
    {
        double m, n, a, b, x,
            z1, z2, y;

        try
        {
            Console.WriteLine("");
            m = ParseDoubleVar(nameof(m));
            n = ParseDoubleVar(nameof(n));
            a = ParseDoubleVar(nameof(a));
            b = ParseDoubleVar(nameof(b));
            x = ParseDoubleVar(nameof(x));

            z1 = Z1(m, n);
            z2 = Z2(m, n);
            y = Y(a, b, x);

            Console.WriteLine($"\nResult:");
            Console.WriteLine($"\tz1 = {z1:0.00}");
            Console.WriteLine($"\tz2 = {z2:0.00}");
            Console.WriteLine($"\ty  = {y:0.00}");
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"\n{ex.Message}");
            Environment.Exit(1);
        }
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

    public static double Z1(double m, double n)
    {
        double denonimator = Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m;

        if (denonimator == 0)
            throw new DivideByZeroException();

        return ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) /
               (denonimator);
    }

    public static double Z2(double m, double n)
    {
        if (m == 0)
            throw new DivideByZeroException();

        return (Math.Sqrt(m) - Math.Sqrt(n)) / m;
    }

    public static double Y(double a, double b, double x)
    {
        if (a == 0)
            throw new DivideByZeroException();

        return 2.4 *
               Math.Abs((x * x + b) / a) +
               (a - b) *
               Math.Pow(Math.Sin(a - b), 2) +
               Math.Pow(10, -2) *
               (x - b);
    }
}
