// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] array = new int[4, 4];
Console.WriteLine();
FillArrayRandom(array);
WriteArray(array);
Console.WriteLine();
int MinSum = Int32.MaxValue;
int indexLine = 0;
MinSumma(array);

void MinSumma(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
       if (sum < MinSum)
       {
            MinSum = sum; 
            indexLine++;
       }
       
    }
}
Console.WriteLine("Cтрокa с наименьшей суммой элементов: " + indexLine);
MinSumma(array);
Console.WriteLine();

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void WriteArray(int[,] array)
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
