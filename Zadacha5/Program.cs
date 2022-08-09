// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

System.Console.WriteLine("Введите трёхзначное число ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 100 && n < 999)
{
    int num = n % 100;
    int n1 = n / 100;
    int n2 = num / 10;
    int n3 = num % 10;
    System.Console.WriteLine("Вторая цифра "+ n2);
}


