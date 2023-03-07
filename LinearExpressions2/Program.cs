internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"Введiть значення для m: ");
        double m = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Введiть значення для n: ");
        double n = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Введiть значення для c: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Введiть значення для d: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Введiть значення для d: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double z1 = (((m - 1) * Math.Sqrt(m)) - ((n - 1) * Math.Sqrt(n))) / ((Math.Sqrt(Math.Pow(m, 3)) * n)) + (m * n) +
        (Math.Pow(m, 2)) - m;
        Console.WriteLine($"Z1 = {z1}");

        double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
        Console.WriteLine($"Z2 = {z1}");

        double y = (2.4 * Math.Abs((Math.Pow(x, 2)) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) +
        Math.Pow(10, -2) * (x - 6));
        Console.WriteLine($"Y = {y}");
    }
}