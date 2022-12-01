// See https://aka.ms/new-console-template for more information
System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                     System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

double a, // число для змінної а
    b, // число для змінної b
    c, // число для змінної c
    d; // число для змінної d

Console.WriteLine("to calculate the formulla, enter the namber a");
a = double.Parse(Console.ReadLine());

Console.WriteLine("to calculate the formulla, enter the namber b");
b = double.Parse(Console.ReadLine());

Console.WriteLine("to calculate the formulla, enter the namber c");
c = double.Parse(Console.ReadLine());

Console.WriteLine("to calculate the formulla, enter the namber d");
d = double.Parse(Console.ReadLine());

double x = ((a + 2.0 * b - c + d) / c * d) + ((a + b) / (c - d)) - ((a * a) / (b * b));
Console.WriteLine($"x = ((a + 2 * b - c + d) / c * d) + ((a + b) / (c - d)) - ((a * a) / (b * b)) = { x }");

double y = ((5.0 * (a + b) * (c - d)) / (1.0 / 2.0 * c)) + ((d * d) * (a * a - b * b) / (b - a));
Console.WriteLine($"y = ((5.0 * (a + b) * (c - d)) / (1.0 / 2.0 * c)) + ((d * d) * ((a * a - b * b) / (b - a)) = { y }");

double z = (((x * x - 2 * x) * (x * x - 2 * x) * (x * x - 2 * x)) - 4 * (x * x * x * x + 1.0)) * (1.0 - b) / (5.0 * a + 3.0 * b);
Console.WriteLine($"z = (((x * x - 2 * x) * (x * x - 2 * x) * (x * x - 2 * x)) - 4 * (x *x*x*x + 1.0)) * (1.0 - b)/(5.0 * a + 3.0 * b) = { z }");

double r = ((1.0 / 2.0 * a) + (3.0 / 4.0 * b) - (7 / 5) / (3.0 * c + 1.0)) + (1.0 / (a - c));
Console.WriteLine($"r = ((1.0 / 2.0 * a) + (3.0 / 4.0 * b) - (7 / 5) / (3.0 * c + 1.0)) + (1.0 / (a - c)) = {r}");

Console.ReadKey();

