//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число для сравнения ");
int namber1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число для сравнения ");
int namber2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число для сравнения ");
int namber3 = Convert.ToInt32(Console.ReadLine());

int max = namber1;
    if (namber1 > max) namber1 = max;
    if (namber2 > max) max = namber2;
    if (namber3 > max) max = namber3;
    
Console.Write("Max = ");
Console.WriteLine(max);


