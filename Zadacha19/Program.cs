// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите число строк m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов n = ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
Console.WriteLine();
fillArrayRandom(array);
writeArray(array);


void fillArrayRandom(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
}
void writeArray(double[,] array)
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