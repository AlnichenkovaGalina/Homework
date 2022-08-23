//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

{
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
        Console.Write(array[i] + " ");
    }
    int max = array[0];
    int min = array[0];
    {
        for (int i = 1; i < array.Length; i++)
            if (min > array[i])
            {
                min = array[i];
            }
            else if (max < array[i])
            {
                max = array[i];
            }
    }

    Console.WriteLine();
    Console.WriteLine($"Разницa между максимальным и минимальным элементов массива: {max - min}");

}


