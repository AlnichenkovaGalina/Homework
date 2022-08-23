// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//static void Main(int[] arrey)
{
    int[] array = new int[10];
    int summ = 0;
    for (int i = 0; i < 10; i++)
    {
        array[i] = new Random().Next(1, 10);
        Console.Write(array[i] + " ");

        if (i % 2 != 0)
        {
            summ = summ + array[i];
        }
    }
    Console.WriteLine();
    Console.Write($"Сумма элементов, стоящих на нечетных позициях: {summ}");
}

