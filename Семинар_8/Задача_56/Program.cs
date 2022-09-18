// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int minSumLine = 0;
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
GetArray(array);
Print(array);

int sumLine = MinSum(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int num = MinSum(array, i);
  if (sumLine > num)
  {
    sumLine = num;
    minSumLine = i;
  }
}


int MinSum(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
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

Console.WriteLine(minSumLine + 1 + " - строкa с наименьшей суммой (" + sumLine + ") элементов ");



