// Найдите произведения пар чисел в одномерном массиве. 
// Парой считается первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

int[] array = new int[6];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    Console.Write(array[i] + " ");

}
int size = array.Length / 2;
int[] result = new int[size];

if (array.Length % 2 == 1) size++;

for (int i = 0; i < array.Length / 2; i++)

{
    result[i] = array[i] * array[array.Length - 1 - i];

    if (array.Length % 2 == 1)

    {
        result[size - 1] = array[array.Length / 2];
    }
    Console.WriteLine();
    Console.Write(result[i] + " ");
}
