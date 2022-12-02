
double[] values = new double[5];
string[] names = new string[5] { "m", "n", "x", "a", "b" };
double m, n, x, a, b, c, z1, z2, y;
for (int i = 0; i < names.Length; i++)
{
    bool wrongValue = false;
    do
    {
        if (wrongValue)
            Console.WriteLine("Wrong value! Try again");
        Console.Write($"{names[i]} = ");
        wrongValue = !double.TryParse(Console.ReadLine(), out values[i]);
    }
    while (wrongValue);
}
m = values[0];
n = values[1];
x = values[2];
a = values[3];
b = values[4];

z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
Console.WriteLine($"Results:\nz1 = {z1}\nz2 = {z2}\ny = {y}");