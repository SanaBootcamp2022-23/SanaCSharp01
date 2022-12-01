double a, b, c, d, x, y, z, r;

Console.Write("Введiть число a: ");
a = double.Parse(Console.ReadLine());

Console.Write("Введiть число b: ");
b = double.Parse(Console.ReadLine());

Console.Write("Введiть число c: ");
c = double.Parse(Console.ReadLine());

Console.Write("Введiть число d: ");
d = double.Parse(Console.ReadLine());

x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - Math.Pow (a, 2) / Math.Pow (b, 2);
y = ((5 * (a + b) * (c - d)) / ((1 / 2.0) * c)) + Math.Pow (d, 2) * ((Math.Pow (a, 2) - Math.Pow (b, 2)) / (b - a)); //не забувати ділити на дробове число з .0
z = ((Math.Pow((Math.Pow(x, 2) - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / (5 * a + 3 * b);
r = (1 / 2.0 * a + 3 / 4.0 * b - 7 / 5.0) / (3 * c + 1) + 1 / (a - c);

Console.WriteLine("Отриманi результати виразiв:");
Console.WriteLine($"x = {x}");
Console.WriteLine($"y = {y}");
Console.WriteLine($"z = {z}");
Console.WriteLine($"r = {r}");
