double a, b, x,n,m, y, z1, z2;
Console.Write("a = ");
a = double.Parse(Console.ReadLine());
Console.Write("b = ");
b = double.Parse(Console.ReadLine());
Console.Write("x = ");
x = double.Parse(Console.ReadLine());
Console.Write("n = ");
n = double.Parse(Console.ReadLine());
Console.Write("m = ");
m = double.Parse(Console.ReadLine());

z1 = ((m - 1) * Math.Sqrt(m) - (n - 1)*Math.Sqrt(n))/(Math.Sqrt(Math.Pow(m,3)*n)+n*m +m*m -m);
z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
y = 2.4 * Math.Abs((x * x+b)/a) + (a-b)*Math.Sin(a-b)*Math.Sin(a-b)+0.01*(x-b);
Console.WriteLine($"z1 = {z1};\nz2 = {z2};\ny = {y};");