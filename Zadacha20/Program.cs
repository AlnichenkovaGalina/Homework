// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Введите число строк m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[10, 10];
Console.WriteLine();
fillArrayRandom(array);
writeArray(array);

if (n > array.GetLength(0) || m > array.GetLength(1))
{
    Console.WriteLine();
    Console.WriteLine("Tакого элемента нет");
}
if (n < array.GetLength(0) && m < array.GetLength(1))
{
    Console.WriteLine();
    Console.WriteLine($"Значение элемента {m} строки и {n} столбца равно {array[m - 1, n - 1]}");
}

void fillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
}
void writeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }

}