using static System.Math;
Console.WriteLine("Enter values (better to avoid 0):");
double m,n,a,b,x;
Console.Write("m: "); m = double.Parse(Console.ReadLine());
Console.Write("n: "); n = double.Parse(Console.ReadLine());
Console.Write("a: "); a = double.Parse(Console.ReadLine());
Console.Write("b: "); b = double.Parse(Console.ReadLine());
Console.Write("x: "); x = double.Parse(Console.ReadLine());

double z1,z2,y;
//z1 = 
if(Sqrt(m*m*m*n)+n*m+m*m-m==0) Console.WriteLine("We cant calculate z1, because of /0");
else
{
    z1 = ((m - 1) * Sqrt(m) - (n - 1) * Sqrt(n)) / (Sqrt(m * m * m * n) + n * m + m * m - m);
    Console.WriteLine($"Result of z1 = {z1}");
}
//z2 =
if(m==0) Console.WriteLine("We cant calculate z2, because of /0");
else
{
    z2 = (Sqrt(m) - Sqrt(n)) / m;
    Console.WriteLine($"Result of z2 = {z2}");
}
//y =
if(a==0) Console.WriteLine("We cant calculate y, because of /0");
else
{
    y = Abs((x * x + b) / a) +(a - b)*Pow(Sin(a-b), 2)+Pow(10,-2)*(x-b);
    Console.WriteLine($"Result of y = {y}");
}