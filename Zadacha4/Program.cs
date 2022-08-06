// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.

Console.WriteLine("Введите число N ");
int namber = Convert.ToInt32(Console.ReadLine());
int count = 1;
Console.WriteLine("Все четные числа от 1 до N ");
while (count <= namber)
{
    if (count % 2 == 0)
    {
        Console.Write(" " + count);
    }
    count++;
}
