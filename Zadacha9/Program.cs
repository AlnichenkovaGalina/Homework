<<<<<<< HEAD
﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
=======
﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними а 3D пространстве.

//static void Main(string[] arg)


Double x1, y1, z1, x2, y2, z2, dis ;
Console.WriteLine("Укажите координаты x1:  ");
 x1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Укажите координаты y1:  ");
 y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Укажите координаты z1:  ");
 z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Укажите координаты x2:  ");
 x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Укажите координаты y2:  ");
 y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Укажите координаты z2:  ");
 z2 = Convert.ToDouble(Console.ReadLine());

dis = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2));

Console.WriteLine("Расстояние между двумя точками в пространстве равно " + dis);
>>>>>>> 38d82f5c91c5112e430771094c01a85a2377158c
