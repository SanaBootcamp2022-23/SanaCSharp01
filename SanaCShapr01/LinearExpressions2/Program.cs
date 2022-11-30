
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Чисто M: ");
        double numberM = Double.Parse(Console.ReadLine());
        Console.Write("Чисто N: ");
        double numberN = Double.Parse(Console.ReadLine());

        double resultZ1 = (((numberM-1)*Math.Sqrt(numberM)) - ((numberN-1)*Math.Sqrt(numberN))) / (Math.Sqrt(Math.Pow(3,numberM) * numberN) + (numberN*numberM) + (Math.Pow(2, numberM) - numberM));
        Console.WriteLine("Z1 = " + resultZ1);

        double resultZ2 = (Math.Sqrt(numberM) - Math.Sqrt(numberN)) / numberM;
        Console.WriteLine("Z2 = " + resultZ2);

        Console.Write("Чисто A: ");
        double numberA = Double.Parse(Console.ReadLine());
        Console.Write("Чисто B: ");
        double numberB = Double.Parse(Console.ReadLine());
        Console.Write("Чисто X: ");
        double numberX = Double.Parse(Console.ReadLine());

        double resultY = (2.4 * Math.Abs((Math.Pow(2, numberX) + numberB) / numberA)) + ((numberA - numberB) * Math.Pow(2, Math.Sin(numberA - numberB))) + (Math.Pow(-2,10)*(numberA-numberB));
        Console.WriteLine("Y = " + resultY);

    }
}