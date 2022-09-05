// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число A:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число B:");
double b = double.Parse(Console.ReadLine());
double stepen = 1;

for (int i = 1; i <= b; i++) 
{
    stepen = stepen * a;
}
Console.WriteLine(stepen);

