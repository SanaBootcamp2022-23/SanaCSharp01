namespace LinearExpressions1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double c = 0;
            double d = 0;

            double x, y, z, r;
            bool isCorrect = false;
            do
            {
                try
                {
                    Console.WriteLine("Enter a:");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter b:");
                    b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter c:");
                    c = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter d:");
                    d = Convert.ToDouble(Console.ReadLine());

                    isCorrect = true;
                }
                catch
                {
                    Console.WriteLine("Error, enter values again");
                    Console.ReadKey();
                }
            }
            while (!isCorrect);

            x = (a + (2 * b) - c + d) / (c * d) + (a + b) / (c - d) - (Math.Pow(a, 2)) / (Math.Pow(b, 2));
            y = (5 * (a + b) * (c - d)) / (1 / 2 * c) + Math.Pow(d, 2) * (Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a);
            z = ((Math.Pow(Math.Pow(x, 2) - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / ((5 * a) + (3 * b));
            r = ((1 / 2 * a) + (3 / 4 * b) - 7 / 5) / (3 * c + 1) + 1 / (a - c);

            Console.WriteLine("(a + (2 * b) - c + d) / (c * d) + (a + b) / (c - d) - (a^2) / (b^2)");
            Console.WriteLine($"x = {x}");

            Console.WriteLine("(5 * (a + b) * (c - d)) / (1 / 2 * c) + d^2 * (a^2 - b^2) / (b - a)");
            Console.WriteLine($"y = {y}");

            Console.WriteLine("( (x^2 - 2 * x, 3) - 4 * (x^4) + 1) * (1 - b)) / ((5 * a) + (3 * b))");
            Console.WriteLine($"z = {z}");

            Console.WriteLine("( (1 / 2 * a) + (3 / 4 * b) - 7 / 5) / (3 * c + 1) + 1 / (a - c)");
            Console.WriteLine($"r = {r}");

        }
    }
}