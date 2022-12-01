// Practical work 03 at Sana Commerce courses. Part 2.
Console.WriteLine("\n\t\t\tHello my dear friend!\n\n" +
                  "\tThis program inserts the variables you enter into the\n" +
                  "\tsecret expressions and calculates the Z1, Z2, and Y values.\n\n" +
                  "\tIf you want to see how it works, input the \"Double\" variables\n" +
                  "\tM, N, X, A and B in sequence on the keyboard and get the result.\n" +
                  "\tIf not, just close the window.\n\n" +
                  "\tFinish entering each variable by pressing the \"Enter\" key.\n");

double variableM, // Variable M entered by the user
       variableN, // Variable N entered by the user
       variableX, // Variable X entered by the user
       variableA, // Variable A entered by the user
       variableB; // Variable B entered by the user

Console.Write("\t\t\tInput variable M: ");
        variableM = double.Parse(Console.ReadLine());
Console.Write("\t\t\tInput variable N: ");
        variableN = double.Parse(Console.ReadLine());
Console.Write("\t\t\tInput variable X: ");
        variableX = double.Parse(Console.ReadLine());
Console.Write("\t\t\tInput variable A: ");
        variableA = double.Parse(Console.ReadLine());
Console.Write("\t\t\tInput variable B: ");
        variableB = double.Parse(Console.ReadLine());

double valueZ1, // The value obtained from the results of the calculation of the first expression
       valueZ2, // The value obtained from the results of the calculation of the second expression
       valueY;  // The value obtained from the results of the calculation of the third expression

       valueZ1 = ((variableM - 1)* Math.Sqrt(variableM) - (variableN - 1) * Math.Sqrt(variableN)) /
                 (Math.Sqrt(Math.Pow(variableM, 3) * variableN) + variableN * variableM + Math.Pow(variableM, 2)
                 - variableM);

       valueZ2 = (Math.Sqrt(variableM) - Math.Sqrt(variableN)) / variableM;

       valueY = 2.4 * Math.Abs((Math.Pow(variableX, 2) + variableB) / variableA) + (variableA - variableB) *
                Math.Pow(Math.Sin(variableA - variableB), 2) + Math.Pow(10, -2) * (variableX - variableB);

Console.WriteLine("\n\t\tAccording to the results of the calculations:\n" +
                 $"\t\t\tZ1 = {valueZ1};\n\t\t\tZ2 = {valueZ2};\n\t\t\tY = {valueY}");

Console.WriteLine("\a");
