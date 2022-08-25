
// Задача 13: Напишите программу, которая выводит третью цифру (справа налево) заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите целое число:");
int num2 = 0;
int num3 = 0;
int num = int.Parse(Console.ReadLine());
if ((num / 100) > 0) 
{
    num2 = num / 100;
    num3 = num2 % 1000;
    num2 = num3 % 10;
    Console.Write(num2);
}
else Console.WriteLine("Третьей цифры нет");