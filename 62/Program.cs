//62. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению.
void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write($" {matr[i, j]} ");
        Console.WriteLine();
    }
}
void FindEvenIndex(double[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)


        for (int j = 0; j < matr.GetLength(1); j++)


            if (i > 0 && j > 0)
                if (i % 2 == 0 && j % 2 == 0)

                    Console.Write($" Четный индекс : {i},{j}");
    Console.WriteLine();
    Console.Write($" Элемент четного индекса : {matr[2, 2]}");
    Console.WriteLine();


}

void ChangeElement(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {

            if (i > 0 && j > 0)
                if (i % 2 == 0 && j % 2 == 0)

                    matr[2, 2] = Math.Pow(matr[2, 2], 2);

        }


    }
}
double[,] matrix = { { 2, 4, 3 }, { 4, 2, 1 }, { 1, 4, 4}, { 3, 2, 1} };
Console.WriteLine("Массив : ");
PrintArray(matrix);
Console.WriteLine();
FindEvenIndex(matrix);
Console.WriteLine();
ChangeElement(matrix);
Console.WriteLine("Измененный: ");
PrintArray(matrix);