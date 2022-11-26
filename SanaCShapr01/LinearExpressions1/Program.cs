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

double a = DoubleInputValue("a = ");
double b = DoubleInputValue("b = ");
double c = DoubleInputValue("c = ");
double d = DoubleInputValue("d = ");

double x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - (Math.Pow(a, 2) / Math.Pow(b, 2));
double y = ((5 * (a + b) * (c - d)) / (0.5 * c)) + (Math.Pow(d, 2) * (Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a));
double z = (Math.Pow((Math.Pow(x, 2) - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1) * (1 - b)) / (5 * a + 3 * b);
double r = ((0.5 * a + 0.75 * b - 7 / 5) / (3 * c + 1) + (1 / (a - c)));

Console.WriteLine("\nResult of calculating:");
Console.WriteLine($"x = {x}");
Console.WriteLine($"y = {y}");
Console.WriteLine($"z = {z}");
Console.WriteLine($"r = {r}");