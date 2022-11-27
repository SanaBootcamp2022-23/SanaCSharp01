using System;
using static System.Math;
double m, n, a, b, x, z1, z2, y;

Console.WriteLine("Enter m:");
m = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter n:");
n = Convert.ToDouble(Console.ReadLine());

z1 = ((m-1)*Sqrt(m)-(n-1)*Sqrt(n))/(Sqrt(Pow(m,3)*n)+n*m+Pow(m,2)-m );
Console.WriteLine("z1={0} \n", z1);

z2 = (Sqrt(m)-Sqrt(n))/m;
Console.WriteLine("z2={0} \n", z2);

Console.WriteLine("Enter a:");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter b:");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter x:");
x = Convert.ToDouble(Console.ReadLine());

y = 2.4 * Abs((Pow(x, 2) + b) / a) + (a - b) * Pow(Sin(a - b), 2) + Pow(10, -2) * (x - b);
Console.WriteLine("y={0} \n", y);