using System.Text;

System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

double a, b , c, d;



a = GetNumber("a");
b = GetNumber("b");
c = GetNumber("c");
d = GetNumber("d");

double x, y, z, r;

x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - ((a * a) / (b * b));
y = (5 * (a + b) * (c - d)) / (( 1 / 2) * c) + (d * d) * ((a * a - b * b) / (b - a));
z = (Math.Pow(x * x - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1) * (1 - b)) / (5 * a + 3 * b);
r = ((1 / 2 * a + 3 / 4 * b - 7 / 5) / (3 * c + 1)) + (1 / (a - c));

ShowResult("x", x); 
ShowResult("y", y);
ShowResult("z", z);
ShowResult("r", r);
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
            Console.WriteLine($"Число {name} записано!");
            break;
        }

    } while (true);
    return number;
}
void ShowResult(string name, double res)
{
    Console.WriteLine($"Результат виразу {name}: {Math.Round(res, 4)}");
}