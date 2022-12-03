double m, n, z1, z2;
Console.WriteLine("Enter values:");
Console.Write("m=");
m = double.Parse(Console.ReadLine());
Console.Write("n=");
n= double.Parse(Console.ReadLine());

z1=((m-1)*Math.Sqrt(m)-(n-1)*Math.Sqrt(n))/(Math.Sqrt(m*m*m*n)+n*m+m*m-m);
z2=(Math.Sqrt(m)-Math.Sqrt(n))/m;
Console.WriteLine($"z1={z1}\nz2={z2}");

double y, x, a, b;
Console.WriteLine("\nEnter values:");
Console.Write("x=");
x=double.Parse(Console.ReadLine());
Console.Write("a=");
a=double.Parse(Console.ReadLine());
Console.Write("b=");
b = double.Parse(Console.ReadLine());

y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
Console.WriteLine($"y={y}");
