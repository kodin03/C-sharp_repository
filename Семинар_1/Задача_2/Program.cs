
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите два целых числа:");
int max = 0;
int min = 0;
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
if (num1 < num2) 
{
    min = num1;
    max = num2;
}
else {
    min = num2;
    max = num1;
}
Console.WriteLine("Меньшее число: " + min);
Console.Write("Большее число: " + max);


