// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


Console.WriteLine("Введите число строк m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
Console.WriteLine();
fillArrayRandom(array);
writeArray(array);
Console.WriteLine();

void arithmeticMain(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double arithmetic = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            arithmetic = arithmetic + array[i, j];
        }
        arithmetic = arithmetic / m;
        Console.Write(arithmetic + "; ");
    }
}
Console.Write("Cреднее арифметическое элементов в каждом столбце: ");
arithmeticMain(array);

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


