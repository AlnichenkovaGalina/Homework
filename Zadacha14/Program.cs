// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//static void Main(int[] arrey)
     {
        int[] array = new int[20];
        int count = 0;
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(100,1000); 
            Console.Write(array[i] + " ");

            if(array[i] % 2 == 0)
            {
                  count++;
            }
                 i=i+1;
           
        }

        Console.WriteLine("Количество четных чисел в массиве: " + count);
    }