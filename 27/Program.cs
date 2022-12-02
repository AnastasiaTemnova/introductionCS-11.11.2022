// 27. Возведите число А в натуральную степень B используя цикл.

System.Console.WriteLine("Введите число A и B");
int A=5;
int B=2;
int i=1;
int sum=1; 

while(i<=B)
{
    sum=sum*A;
    i++;
}


System.Console.WriteLine(sum);