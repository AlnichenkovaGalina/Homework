
// Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.

    Console.WriteLine("Введите число N:  ");
    
    int numb = Convert.ToInt32(Console.ReadLine());
    string a = Convert.ToString(numb);
    
    int count = 1;
    int i = 0;
    int Length = a.Length;
    Console.WriteLine("Tаблица кубов чисел от 1 до N:  ");
    while(count <= Length)
    {
      for (i = 1; i <= numb; i++)
      {
        Console.WriteLine(i * i * i + " ");
        }
      count++;
    }
    

 
