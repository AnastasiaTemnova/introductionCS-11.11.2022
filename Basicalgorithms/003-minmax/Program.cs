﻿/* Программа,которая в последовательности натуральны хчисел определяет минимальное число,
 оканчивающее на 4.
На входе: количество чисел в последовательности, а затем сами числа.
в последовательности всегда имеется число, оканчивающееся на 4.
количество чисел не прпевышает 1000, введенные числа не превышают 30 000,
программа должна вывестиодно число- минимальное, оканчивающееся на 4.
*/

int n=Convert.ToInt32(Console.ReadLine());
int min=30000;
for(int i=0;i<n;i++)
{

int a=Convert.ToInt32(Console.ReadLine());
if(a<min && a%10==4) min=a;
}
System.Console.WriteLine(min);