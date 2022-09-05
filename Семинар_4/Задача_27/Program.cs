// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите цифру:");
int num2 = 0;
int num3 = 0;
int num = int.Parse(Console.ReadLine());
num3 = num;

while (num > 0) 
{
    num3 = num % 10;
    num/=10;
    num2 = num3 + num2;
}
Console.WriteLine(num2);
