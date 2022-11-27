Console.WriteLine("Enter the four numbers - m,n,x,b,a.");
double m, n, x, a , b;
Console.Write("Enter the \'m\': ");
if (!double.TryParse(Console.ReadLine(), out m)) return;
Console.Write("Enter the \'n\': ");
if (!double.TryParse(Console.ReadLine(), out n)) return;
Console.Write("Enter the \'a\': ");
if (!double.TryParse(Console.ReadLine(), out a)) return;
Console.Write("Enter the \'b\': ");
if (!double.TryParse(Console.ReadLine(), out b)) return;
Console.Write("Enter the \'x\': ");
if (!double.TryParse(Console.ReadLine(), out x)) return;
Console.WriteLine($"You enter a={m}, b={n}.");
if (m!=0)
{
    double z1, z2, y;
    z1 = ((m-1)*Math.Sqrt(m)-(n-1)*Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
    z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
    y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Sin(Math.Pow(a - b, 2)) + Math.Pow(10, -2) * (x - b);
    Console.Write($"1. z1 = {z1}\n" +
        $"2. z2 = {z2}\n" +
        $"3. y = {y}\n");
}
else
    Console.WriteLine("Incorect numbers");
