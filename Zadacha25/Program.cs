// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.WriteLine("Введите число M ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());

string recursion(int M, int N)
{

    if (M > N)
    {
        if (M == N)
        {
            return $"{M} ";
        }
        return $"{M} " + recursion(M - 1, N);
    }
    else
    {
        if (M == N)
        {
            return $"{M} ";
        }
        return $"{M} " + recursion(M + 1, N);
    }
}

Console.WriteLine("Все натуральные числа в промежутке от M до N ");
Console.WriteLine(recursion(M, N));
