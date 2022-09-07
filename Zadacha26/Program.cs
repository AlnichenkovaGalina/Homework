
//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Введите число M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N ");
int n = Convert.ToInt32(Console.ReadLine());


int SumRec(int m, int n)
{
    if (m < n)
    {
        if (m == n)
        {
            return n;
        }
        return n + SumRec(m, n - 1);

    }
    else
    {
        if (m == n)
        {
            return n;
        }
        return n + SumRec(m, n + 1);

    }
}

Console.WriteLine("Сумма натуральных элементов в промежутке от M до N ");
Console.WriteLine(SumRec(m, n));
