// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. 

int num = 0;
//int count;

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
        num = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            num += array[j, i];
        }
        Console.Write(num / array.GetLength(1) + " ");
    }
}

// Метод нужен для определения точности ответа
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

int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int min = new Random().Next(0, 10);
int max = new Random().Next(10, 20);

int[,] myArray = GetArray(m, n, min, max);
Print(myArray);

Console.WriteLine("Результат:");
Check(myArray);