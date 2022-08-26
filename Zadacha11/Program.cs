
//Напишите цикл, в который принимает на вход два числа А и В, и возводит число А в натуральную степень В.

Console.WriteLine("Введите число А ");
double namberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B ");
double namberB = Convert.ToInt32(Console.ReadLine());
double result = 1;
double i = 0;
while (i <= namberB - 1)
{
    result = result * namberA;
    i++;

}

Console.WriteLine("Число А в степени В равно: " + result);