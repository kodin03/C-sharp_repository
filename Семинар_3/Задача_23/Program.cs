// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число:");
double n = double.Parse(Console.ReadLine());
double cube = 0;

for (int i = 1; i <= n; i++) 
{
    cube = Math.Pow(i, 3.0);
    if (i == n) Console.Write(cube);
    else Console.Write(cube + ", ");
}

