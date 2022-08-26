// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
string b = Convert.ToString(n);
if (b.Length < 3)
{
    System.Console.WriteLine("Третьей цифры нет ");
}
else
{
    System.Console.WriteLine("Третья цифра " + b [2]);
}