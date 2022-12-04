using System.Text;
using System.Threading.Tasks.Dataflow;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode; 

Console.Write("Введіть а: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введіть b: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Введіть c: ");
double c = double.Parse(Console.ReadLine());
Console.Write("Введіть d: ");
double d = double.Parse(Console.ReadLine());

double x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - a * a / (b * b);
double y = 5 * (a + b) * (c - d) / (c / 2) + d * d * (a * a - b * b) / (b - a);
double z = (Math.Pow(x * x - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1) * (1 - b)) / (5 * a + 3 * b);
double r = (a / 2 + 3 * b / 4 - 7 / 5.0) / (3 * c + 1) + 1 / (a - c);
Console.WriteLine($"Значення х: {x}\nЗначення y: {y}\nЗначення z: {z}\nЗначення r: {r}");
