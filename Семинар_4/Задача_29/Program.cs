// Напишите программу, которая задаёт массив из N элементов, заполненных случайнми числами из [a, b) и выводит их на экран.

Console.WriteLine("Введите количество чисел:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите начало диапазона чисел:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конец диапазона чисел:");
int b = int.Parse(Console.ReadLine());
int[] num = new int[n];
Random random = new Random();


for (int i = 0; i < n; i++) 
{
    int number = random.Next(a, b);
    num[i] = number;
    if (i == n-1) Console.Write(num[i]);
    else Console.Write(num[i] + ", ");
}
