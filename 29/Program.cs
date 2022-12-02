//29.  Подсчитать сумму цифр в числе. Сделать подпрограмму.

void Summ(int x, int a1, int a2, int a3)

{

        if (x>=10 && x<=999)
        {
                a1 = x/100;
                a2 = x%100/10;
                a3 = x%10;

             Console.WriteLine($"{a1+a2+a3}");
        }



        else 
        {
            Console.WriteLine("Введите другое число");

        }
}

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine()?? "0");
int number1 = 0;
 int number2 = 0 ;
  int number3 = 0;
Summ(n, number1, number2, number3);