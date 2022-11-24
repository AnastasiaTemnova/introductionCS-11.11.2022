// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
int a=0,b=0,c=0;// целый
float f=20.4f;//32 бит
double d=3.14;// вещественный 64бит
string s="asdasd";
char co='a';
bool flag=true;
int переменная1-1;
*/

//1. С клавиатуры вводится целое число. Вывести квадрат числа (блок-схема)

int a;
a=10;
System.Console.Write("Введите число");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
int b=a*a;
System.Console.WriteLine(Convert.ToString (a)+"^2="+b.ToString());
System.Console.WriteLine("{0}^2={1}", a,b);
System.Console.WriteLine($"{a}^2={b}");

