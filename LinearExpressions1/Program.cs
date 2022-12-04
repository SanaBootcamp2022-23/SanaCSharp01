Console.WriteLine("--- Вас вiтає програма обчислення чисел ---");

double a, b, c, d;

Console.WriteLine("--- Дробовi числа вводити через кому <,> ---");

Console.Write("Введiть число а: ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введiть число b: ");
b = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Введiть число c: ");
c = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Введiть число d: ");
d = Convert.ToDouble(Console.ReadLine());

double x, y, z, r;

x = (a + 2 * b - c + d) / (c * d) + ((a + b) / (c - d)) - ((Math.Pow(a, 2)) / (Math.Pow(b, 2)));

y = (5 * (a+b)*(c-d))/(c/2)+Math.Pow(d, 2)*(Math.Pow(a,2) - Math.Pow(b, 2))/(b-a);

z = (Math.Pow((Math.Pow(x, 2) - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1)*(1 - b)) / (5*a + 3*b);

r = (a/2 + 3 * b / 4 - 7 * Math.Pow(5, -1)) / (3 * c + 1) + (1 / (a - c));

Console.WriteLine("--- Число x:" + x);
Console.WriteLine("--- Число y:" + y);
Console.WriteLine("--- Число z:" + z);
Console.WriteLine("--- Число r:" + r);
