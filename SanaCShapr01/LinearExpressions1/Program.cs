using System.Security.Cryptography.X509Certificates;

double a, b, c, d,y,z,x,r;
Console.WriteLine("Введiть a:");
a =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введiть b:");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введiть c:");
c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введiть d:");
d = Convert.ToDouble(Console.ReadLine());
x=((a+2*b-c+d)/(c*d))+((a + b) / (c - d)) - (Math.Pow(a, 2) / Math.Pow(b, 2));
y = ((5 * (a + b) * (c - d)) / (1.0/2 * c)) + (d * d) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a));
z = ((Math.Pow(Math.Pow(x, 2) - 2 * x, 3)) - 4 * (Math.Pow(x, 4) + 1) * (1 - b)) / (5 * a + 3 * b);
r = ((((1.0 / 2) * a) + ((3.0 / 4) * b) - (7.0 / 5)) / (3 * c + 1)) + (1 / (a - c));
Console.WriteLine("Результат x:" + x);
Console.WriteLine("Результат y:" + y);
Console.WriteLine("Результат z:" + z);
Console.WriteLine("Результат r:" + r);