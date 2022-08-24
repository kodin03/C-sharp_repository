Console.WriteLine("Введите три целых числа:");
int max = 0;
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
if (num1 > num2) max = num1;
else max = num2;
if (num3 > max) max = num3;
Console.Write("Максимум: " + max);
