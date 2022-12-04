double a, b, m, n, x;

Console.WriteLine("Hello, please, enter linear data for computing expressions");

a = enterData("a =");
b = enterData("b =");
x = enterData("x =");

m = enterData("m =");
n = enterData("n =");

outResult("z1 = ", computeZ1(m,n));
outResult("z2 = ", computeZ2(m,n));
outResult("y = ", computeY(a,b,x));



double computeY(double a, double b, double x)
{
    double firstPart = 2.4 * Math.Abs((Math.Pow(x,2) + b)/a);
    double secondPart = (a - b) / Math.Pow(Math.Sin(a - b),2);
    double thirdPart = (x - b) * Math.Pow(10,-2);
    return firstPart + secondPart + thirdPart;
}

double computeZ1(double m, double n)
{
    return ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / 
        (Math.Sqrt(Math.Pow(m,3) * n) + n * m + Math.Pow(m,2) - m);
}
double computeZ2(double m, double n)
{
    return (Math.Sqrt(m) - Math.Sqrt(n)) / m;
}


void outResult(string s, double x)
{
    Console.WriteLine(s + x);
}


double enterData(String s)
{
    Console.WriteLine(s);
    string consoleString = Console.ReadLine();
    return double.Parse(consoleString);
}
