double a, b, c, d,x,y,z,r;
Console.WriteLine("Введіть а");
a=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введіть b");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введіть c");
c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введіть d");
d = Convert.ToDouble(Console.ReadLine());
x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - ((a * a) / (b * b));
y = ((5 * (a + b) * (c - d)) / (1.0 / 2 * c)) + (d * d) * (Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a);
z = ((Math.Pow((x * x) - (2 * x), 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / (5 * a + 3 * b);
r = ((1.0 / 2 * a + 3.0 / 4 * b - 7.0 / 6) / (3 * c + 1)) + 1 / (a - c);
Console.WriteLine("x="+x);
Console.WriteLine("y="+y);
Console.WriteLine("z="+z);
Console.WriteLine("r="+r);


