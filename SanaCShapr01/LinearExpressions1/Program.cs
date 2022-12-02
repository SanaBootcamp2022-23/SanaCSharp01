double a, b, c, d, x, y, z, r;
Console.WriteLine("Введiть число а :");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введiть число b :");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введiть число c :");
c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введiть число d :");
d = Convert.ToDouble(Console.ReadLine());

x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - (Math.Pow(a, 2) / Math.Pow(b, 2));
y = ((5 * (a + b) * (c - d)) / (1.0 / 2.0 * c)) + Math.Pow(d, 2) * (((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a)));
z = ((Math.Pow((Math.Pow(x, 2) - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / (5 * a + 3 * b);
r = ((1.0 / 2.0 * a) + (3.0 / 4.0 * b) - 7.0 / 5.0) / (3 * c + 1) + 1 / (a - c);
Console.WriteLine($"Вiдповiдi x= {Math.Round(x, 2)},y= {Math.Round(y, 2)},z= {Math.Round(z, 2)},r= {Math.Round(r, 2)} ");

