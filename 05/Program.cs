// 05. С клавиатуры вводятся три числа. Найти максимальное из трех чисел

// double a=Convert.ToDouble(Console.ReadLine());
//double b=Convert.ToDouble(Console.ReadLine());
//double c=Convert.ToDouble(Console.ReadLine());
//if (a<b) System.Console.WriteLine (b);
//if (b<c) System.Console.WriteLine (c);
//else  System.Console.WriteLine (a); 



int a= Convert.ToInt32(Console.ReadLine());
int b= Convert.ToInt32(Console.ReadLine());
int c= Convert.ToInt32(Console.ReadLine());
int max=0;
if (a>b) max=a;
if (b>c) max=b;
if(c>a) max=c;
System.Console.WriteLine($"Max={max}");