// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите цифру:");
int num2 = 0;
int num3 = 0;
//int j = 1;
int num = int.Parse(Console.ReadLine());
num3 = num;

while (num3 > 0) 
{
    num2 = (num2 * 10) + (num3 % 10);
    num3/=10;
}
if (num == num2) Console.WriteLine("Да");
else Console.WriteLine("Нет");
