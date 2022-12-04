// See https://aka.ms/new-console-template for more information
System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введіть значення змінної A -> ");
double varA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введіть значення змінної B -> ");
double varB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введіть значення змінної C -> ");
double varC = Convert.ToDouble(Console.ReadLine());
Console.Write("Введіть значення змінної D -> ");
double varD = Convert.ToDouble(Console.ReadLine());


double resultX = (varA + 2 * varB - varC + varD) / (varC * varD) + (varA + varB) / (varC - varD) - Math.Pow(varA, 2) / Math.Pow(varB, 2);
Console.WriteLine(resultX);

double resultY = (5 * (varA + varB) * (varC - varD)) / (1 / 2.0 * varC) + Math.Pow(varD, 2) * ((Math.Pow(varA, 2) - Math.Pow(varB, 2)) / (varB - varA));
Console.WriteLine(resultY);


Console.Write("Введіть значення змінної X -> ");
double varX = Convert.ToDouble(Console.ReadLine());
double resultZ = (Math.Pow(varX*varX - 2 * varX, 3) - 4 * (Math.Pow(varX, 4) + 1)) * (1 - varB) / (5 * varA + 3 * varB);
Console.WriteLine(resultZ);
