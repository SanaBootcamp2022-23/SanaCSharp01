
using System.Security.Cryptography.X509Certificates;

double m, n,a,b,x;

Console.WriteLine("input m:");
m = double.Parse(Console.ReadLine());

Console.WriteLine("input n:");
n = double.Parse(Console.ReadLine());


Console.WriteLine("input a:");
a = double.Parse(Console.ReadLine());

Console.WriteLine("input b:");
b = double.Parse(Console.ReadLine());

Console.WriteLine("input x:");
x = double.Parse(Console.ReadLine());



double z1 = (m-1)* (Math.Sqrt(m)) - ((n-1)*(Math.Sqrt(n))/(Math.Sqrt(Math.Pow(m,3))*n)+(n*m)+(Math.Pow(m,2))- m) ;
Console.WriteLine("z1 = {0}", z1);

double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
Console.WriteLine("z2 = {0}", z2);

double y=2.4*Math.Abs((Math.Pow(x,2)+b)/a) + (a-b)*Math.Pow(Math.Sin(a-b),2)+Math.Pow(10,-2)*(x-b);
Console.WriteLine("y = {0}", y);