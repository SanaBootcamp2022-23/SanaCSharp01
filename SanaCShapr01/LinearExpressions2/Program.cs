namespace LinearExpressions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("The program \"LinearExpressions2\"\n");

                Console.WriteLine("Please enter double input values.");
                var numberA = ReadDouble("a");
                var numberB = ReadDouble("b");
                var numberX = ReadDouble("x");
                var numberN = ReadDouble("n");
                var numberM = ReadDouble("m");

                var resultZ1 = CalculateZ1(numberN ,numberM);
                var resultZ2 = CalculateZ2(numberN ,numberM);
                var resultY = CalculateY(numberA, numberB, numberX);

                Console.WriteLine("\nRESULTS:");
                Console.WriteLine($"Z1 = {resultZ1}" +
                    $"\nZ2 = {resultZ2}" +
                    $"\nY = {resultY}");

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n{ex.Message}");
            }
        }

        static double ReadDouble(string label)
        {
            double number;

            Console.Write($"\"{label}\" = ");
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine($"Error! The number \"{label}\" is not correct!");
                Console.Write($"Please repeat entering a double value.\n\n\"{label}\" = ");
            }

            return number;
        }

        static double CalculateZ1(double n, double m)
        {
            var denominator = Math.Sqrt(Math.Pow(m, 3.0) * n) + n * m + m * m - m;

            if (denominator == 0)
            {
                throw new DivideByZeroException("A division by zero error occurred when calculating Z1");
            }

            var numerator = (m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n);
            return Math.Round(numerator / denominator, 3);
        }

        static double CalculateZ2(double n, double m)
        {
            if (m == 0)
            {
                throw new DivideByZeroException("A division by zero error occurred when calculating Z2");
            }

            var result = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            return Math.Round(result, 3);
        }

        static double CalculateY(double a, double b, double x)
        {
            if (a == 0)
            {
                throw new DivideByZeroException("A division by zero error occurred when calculating Z2");
            }

            var result  = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Sin(a - b)
                * Math.Sin(a - b) + (1.0 / 100) * (x - b);

            return Math.Round(result, 3);
        }
    }
}