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
