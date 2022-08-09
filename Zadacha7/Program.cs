//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

static void DayOfTheWeek()
{
    string[] namesDay = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
    for (int i = 0; i < namesDay.Length-1; i++)
    {
        Console.Write(i+1 + " - " + namesDay[i] + ", ");
    }
    Console.WriteLine(namesDay.Length + " - " + namesDay[namesDay.Length - 1] + ".");
    Console.WriteLine("Выберите день недели ");
    int numberDay = Convert.ToInt32(Console.ReadLine());
    if (numberDay < 6)
    {
        Console.WriteLine("День недели " + namesDay[numberDay - 1] + " - " + " не выходной ");
    }
    else
    {
        Console.WriteLine("День недели " + namesDay[numberDay - 1] + " - " + " выходной ");
    }
}

{
    DayOfTheWeek();
}