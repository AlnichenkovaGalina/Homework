// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("Введите число M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N ");
int n = Convert.ToInt32(Console.ReadLine());

int recursion(int m, int n) 
{
        // Базовый случай
        if (m == 0) {
            return n + 1;
        } // Шаг рекурсии / рекурсивное условие
        else if (n == 0 && m > 0) {
            return recursion(m - 1, 1);
        } // Шаг рекурсии / рекурсивное условие
        else {
            return recursion(m - 1, recursion(m, n - 1));
        }
}
Console.WriteLine("Значение вычисления функции Аккермана с помощью рекурсии: ");
Console.WriteLine(recursion(m, n));