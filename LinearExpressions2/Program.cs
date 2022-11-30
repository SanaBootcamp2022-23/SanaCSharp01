// See https://aka.ms/new-console-template for more information

System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

double m, n, x, a, b;
Console.WriteLine("Enter the value m");
m = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the value n");
n = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the value x");
x = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the value a");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the value b");
b = double.Parse(Console.ReadLine());

double z1 = (((m - 1) * Math.Sqrt(m)) - ((n- 1.0) * Math.Sqrt(n))) / (Math.Sqrt(Math.Pow(m, 3) * n) + (n * m) + Math.Pow(m, 2) - m);

double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;

double y = 2.4 * (Math.Abs((Math.Pow(x, 2) + b) / a)) + ((a - b) * Math.Pow(Math.Sin(a - b), 2)) + (Math.Pow(10.0, -2) * (x - b));

Console.WriteLine(
    $"The first formula Z1 = {z1} \n" +
    $"The second formula Z2 = {z2} \n" +
    $"The third formula Y = {y} \n");