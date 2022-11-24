//03. С клавиатуры вводятся два числа a и b. Найти максимальное из них.

double a=Convert.ToDouble(Console.ReadLine());
double b=Convert.ToDouble(Console.ReadLine());

if (a>b) System.Console.WriteLine ($"{a} является максимальным");
if (a<b) System.Console.WriteLine ($"{b} является максимальным");