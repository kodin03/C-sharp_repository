
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру дня недели:");
int num2 = 0;
int num = int.Parse(Console.ReadLine());

if ((num / 6 == 1) || (num % 6 == 1) || (num % 6 == 2) || (num % 6 == 3) || (num % 7 == 0)) 
{
    Console.WriteLine($"Выходной");
}
else Console.WriteLine($"Будний");
