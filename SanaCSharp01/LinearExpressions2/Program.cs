// See https://aka.ms/new-console-template for more information

double NumberA;
double NumberB;
double NumberN;
double NumberM;
double NumberX;

Console.WriteLine("Enter the number A:");
NumberA = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the number B:");
NumberB = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the number N:");
NumberN = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the number M:");
NumberM = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the number X:");
NumberX = double.Parse(Console.ReadLine());

double ResultZ1 =
    ((NumberM - 1) * Math.Sqrt(NumberM) - (NumberN - 1) * Math.Sqrt(NumberN)) / ((Math.Sqrt(Math.Pow(NumberM, 3) * NumberN) + NumberN * NumberM + Math.Pow(NumberM, 2) - NumberM));
Console.WriteLine($"Result Z1: \n {ResultZ1}");

double ResultZ2 =
    (Math.Sqrt(NumberM) - Math.Sqrt(NumberN) / NumberM);
Console.WriteLine($"Result Z2: \n {ResultZ2}");

double ResultY =
    (2.4 * Math.Abs((Math.Pow(NumberX, 2) + NumberB) / NumberA) + (NumberA - NumberB) * (Math.Pow(Math.Sin(NumberA - NumberB), 2)) + Math.Pow(10, -2) * (NumberX - NumberB));
Console.WriteLine($"Result Y: \n {ResultY}");
