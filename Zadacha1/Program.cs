// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число для сравнения ");
int namber1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число для сравнения ");
int namber2 = Convert.ToInt32(Console.ReadLine());

int max = namber1;
if (namber1 > namber2)
{
    namber1 = max;
    Console.WriteLine("Большее число " + namber1);
    Console.WriteLine("Меньшее число " + namber2);
}
else if (namber2 > namber1)
{
    Console.WriteLine("Большее число " + namber2);
    Console.WriteLine("Меньшее число " + namber1);
}
else
    Console.WriteLine("Эти числа равны");