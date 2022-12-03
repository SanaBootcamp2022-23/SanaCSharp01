double a, b, c, d,x,y,z,r;
Console.WriteLine("Enter a");
Console.Write(">");

a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter b");
Console.Write(">");

b = double.Parse(Console.ReadLine());
Console.WriteLine("Enter c");
Console.Write(">");
c = double.Parse(Console.ReadLine());
Console.WriteLine("Enter d");
Console.Write(">");

d = double.Parse(Console.ReadLine());

Console.WriteLine("Calculating");
x = (a + 2 * b - c + d) / c * d + (a + b) / (c + d) - (a * a) / (b * b);
Console.WriteLine("Calculating.");

y = (5 * (a + b) * (c - d)) / (0.5 * c) + d * d * ((a * a) - (b * b) - b - a);
Console.WriteLine("Calculating..");

z = (Math.Pow((x * x - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1) * (1 - b))/(5*a+3*b);
Console.WriteLine("Calculating...");

r = (a / 2 + b * 3 / 4 - 7 / 5) / 3 * c + 1 + 1 / (a - c);

Console.WriteLine("x:"+x);
Console.WriteLine("y:"+y);
Console.WriteLine("z:"+z);
Console.WriteLine("r:"+r);