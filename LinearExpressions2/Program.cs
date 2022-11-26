using System.Text;

System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

double m, n, x, a, b;

m = GetNumber("m");
n = GetNumber("n");
x = GetNumber("x");
a = GetNumber("a");
b = GetNumber("b");

double z1, z2, y;

z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + m * m - m);
z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
y = 2.4 * Math.Abs((x * x + b) / a) + (a + b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);

ShowResult("z1", z1);
ShowResult("z2", z2);
ShowResult("y", y);
Console.ReadKey();

double GetNumber(string name)
{
    double number;
    do
    {
        Console.WriteLine($"Введіть число {name}:");
        if (!double.TryParse(Console.ReadLine(), out number))
            Console.WriteLine($"Помилка у введені числа! Спробуйте ще раз. \nВведіть числo {name}:");
        else
        {
            Console.WriteLine($"Число {number} записано!");
            break;
        }

    } while (true);
    return number;
}

void ShowResult(string name, double res)
{
    Console.WriteLine($"Результат виразу {name}: {Math.Round(res, 4)}");
}