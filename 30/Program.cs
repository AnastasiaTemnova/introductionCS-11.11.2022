// 30.Написать программу вычисления произведения чисел от 1 до N


Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int factorial(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
    result=result*i;
    }
    return result;
}
Console.WriteLine(factorial(number));