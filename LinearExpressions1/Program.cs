internal class Program
{
    private static void Main(string[] args)
    {
        double[] values = new double[4];
        string[] names = new string[4] { "a", "b", "c", "d" };
        double a, b, c, d, x, y, z, r;
        Console.WriteLine("Enter variable values:");
        for (int i = 0; i < names.Length; i++)
        {
            bool wrongValue = false;
            do
            {
                if (wrongValue)
                    Console.WriteLine("Wrong value! Try again");
                Console.Write($"{names[i]} = ");
                wrongValue = !double.TryParse(Console.ReadLine(), out values[i]);
            }
            while (wrongValue);
        }
        a = values[0];
        b = values[1];
        c = values[2];
        d = values[3];

        x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - Math.Pow(a, 2) / Math.Pow(b, 2);
        y = 5 * (a + b) * (c - d) / (1.0 / 2.0 * c) + Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a));
        z = (Math.Pow((Math.Pow(x, 2) - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) / (5 * a + 3 * b);
        r = (1.0 / 2 * a + 3.0 / 4 * b - 7.0 / 5) / (3 * c + 1) + (1 / (a - c));
        Console.WriteLine($"\nResults:\nx = {x}\ny = {y}\nz = {z}\nr = {r}");
    }
}