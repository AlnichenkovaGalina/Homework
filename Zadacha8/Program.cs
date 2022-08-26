// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


Console.WriteLine("Введите пятизначное число ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 10000 && n < 99999)
{

    int n1 = n / 10000;
    int n2 = n % 10000 / 1000;
    int n3 = n % 1000 / 100;
    int n4 = n % 100 / 10;
    int n5 = n % 10;

    if (n1 == n5 && n2 == n4)
    {
       Console.WriteLine(n + " - число палиндром");
    }

    else
    {
       Console.WriteLine(n + " - число не палиндром");
    }

}
