double DoubleInputValue(string text)
{
    bool check = false;
    double val = 0;
    while (!check)
    {
        Console.Write(text);
        check = double.TryParse(Console.ReadLine(), out val);
        if (!check)
        {
            Console.WriteLine("Incorect input, you must write double value.");
        }
    }
    return val;
}

double m = DoubleInputValue("m = ");
double n = DoubleInputValue("n = ");
double x = DoubleInputValue("x = ");
double a = DoubleInputValue("a = ");
double b = DoubleInputValue("b = ");

double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
double y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);

Console.WriteLine("\nResult of calculating:");
Console.WriteLine($"z1 = {z1}");
Console.WriteLine($"z2 = {z2}");
Console.WriteLine($"y = {y}");