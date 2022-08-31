// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] array1 = new int[2, 2];
int[,] array2 = new int[2, 2];
int[,] Matrix = new int[2, 2];
Console.WriteLine();
FillArrayRandom(array1);
FillArrayRandom(array2);
WriteArray(array1);
Console.WriteLine();
WriteArray(array2);
Console.WriteLine();
ProductMatrix(Matrix);
Console.WriteLine("Произведение двух матриц: ");
WriteArray(Matrix);

void ProductMatrix (int[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                Matrix [i,j] = Matrix [i,j] + (array1[i,k]*array2[k,j]);
          
            }
        }

    }
}


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
