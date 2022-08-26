// Напишите программу, которая принимает число на вход и выдает сумму цифр в числе.

Console.WriteLine("Введите число n  ");
int n = Convert.ToInt32(Console.ReadLine());
int summ = 0;

while (n > 0)
{
    int numb = n % 10;
    n = n / 10;
    summ = summ + numb;  
}
Console.WriteLine("Сумма цифр в числе: " + summ);