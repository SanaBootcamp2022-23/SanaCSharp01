namespace LinearExpressions1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("The program \"LinearExpressions1\"\n");

                Console.WriteLine("Please enter double input values.");
                var numberA = ReadDouble("a");
                var numberB = ReadDouble("b");
                var numberC = ReadDouble("c");
                var numberD = ReadDouble("d");
                var numberX = ReadDouble("x");

                var resultX = CalculateX(numberA, numberB, numberC, numberD);
                var resultY = CalculateY(numberA, numberB, numberC, numberD);
                var resultZ = CalculateZ(numberA, numberB, numberX);
                var resultR = CalculateR(numberA, numberB, numberC);

                Console.WriteLine("\nRESULTS:");
                Console.WriteLine($"X = {resultX}" +
                    $"\nY = {resultY}" +
                    $"\nZ = {resultZ}" +
                    $"\nR = {resultR}");

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

        static double CalculateX(double a, double b, double c, double d)
        {
            if (c * d == 0 || c - d == 0 || b * b == 0)
            {
                throw new DivideByZeroException("A division by zero error occurred when calculating X");
            }

            var result = (a + 2 * b - c + d) / (c * d);
            result += (a + b) / (c - d);
            result -= a * a / (b * b);

            return Math.Round(result, 3);
        }

        static double CalculateY(double a, double b, double c, double d)
        {
            if (0.5 * c == 0 || b - a == 0)
            {
                throw new DivideByZeroException("A division by zero error occurred when calculating Y");
            }

            var result = (5 * (a + b) * (c - d)) / (0.5 * c);
            result += d * d * ((a * a - b * b) / (b - a));
            return Math.Round(result, 3);
        }

        static double CalculateZ(double a, double b, double x)
        {
            if (5 * a + 3 * b == 0)
            {
                throw new DivideByZeroException("A division by zero error occurred when calculating Z");
            }

            var result = (Math.Pow(x * x - 2 * x, 3.0) - 4 * (Math.Pow(x, 4.0) + 1) * (1 - b)) / (5 * a + 3 * b);
            return Math.Round(result, 3);
        }

        static double CalculateR(double a, double b, double c)
        {
            if (3 * c + 1 == 0 || a - c == 0)
            {
                throw new DivideByZeroException("A division by zero error occurred when calculating R");
            }

            var result = (0.5 * a + 0.75 * b - 7.0 / 5) / (3 * c + 1);
            result += 1 / (a - c);
            return Math.Round(result, 3);
        }
    }
}