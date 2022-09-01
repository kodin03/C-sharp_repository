// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите X первой точки:");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Y первой точки:");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Z первой точки:");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите X второй точки:");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Y второй точки:");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Z второй точки:");
double z2 = double.Parse(Console.ReadLine());
double answer = 0;

answer = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0) + Math.Pow(z2 - z1, 2.0));

Console.WriteLine(answer);
