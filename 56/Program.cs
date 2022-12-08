//56.Написать программу копирования массива

int[] array = new int[5];
int arrayCopy;

Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    arrayCopy = array[i];
    Console.Write(arrayCopy + " ");
}