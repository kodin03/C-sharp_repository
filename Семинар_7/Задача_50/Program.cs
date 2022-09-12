/* Напишите программу, которая на вход принимает число и генерирует случайный двумерный массив, 
и возвращает индексы этого элемента или же указание, что такого элемента нет. */

int num = 0;
int count = 0;

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    for(int i = 0; i < m; i++)
    for (int j = 0; j < n; j++) 
    {
        array[i, j] = new Random().Next(min, max + 1);
    }
    return array;
}

void Check(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num) 
            {
                Console.Write(i + ", " + j);
                count++;
            }
        }
    }
    if (count == 0) Console.Write("Такого элемента нет");
}

void Print(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int m = new Random().Next(0, 5);
int n = new Random().Next(0, 6);
int min = new Random().Next(0, 49);
int max = new Random().Next(50, 99);

int[,] myArray = GetArray(m, n, min, max);
Print(myArray);

Console.WriteLine("Введите число:");
num = int.Parse(Console.ReadLine());

Check(myArray);