// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Введите число строк 1-й матрицы: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов 1-й матрицы и строк 2-й: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов 2-й матрицы: ");
int p = int.Parse(Console.ReadLine());


int[,] first = new int[m, n];
GetArray(first);
Console.WriteLine("Первая матрица:");
Print(first);

int[,] second = new int[n, p];
GetArray(second);
Console.WriteLine("Вторая матрица:");
Print(second);

int[,] result = new int[m,p];

MultiplyMatrix(first, second, result);
Console.WriteLine("Произведение первой и второй матриц:");
Print(result);

void MultiplyMatrix(int[,] first, int[,] second, int[,] result)
{
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < first.GetLength(1); k++)
      {
        sum += first[i,k] * second[k,j];
      }
      result[i,j] = sum;
    }
  }
}

void GetArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(0, 99);
    }
  }
}

void Print(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}