// Напишите программу, которая заполнит спирально массив 4 на 4.

int m = 4;
int[,] array = new int[m, m];

int count = 1;
int i = 0;
int j = 0;

while (count <= array.GetLength(0) * array.GetLength(1))
{
  array[i, j] = count;
  count++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array.GetLength(1) - 1)
    j--;
  else
    i--;
}

Print(array);

void Print (int[,] arraytwo)
{
  for (int i = 0; i < arraytwo.GetLength(0); i++)
  {
    for (int j = 0; j < arraytwo.GetLength(1); j++)
    {
      if (arraytwo[i,j] / 10 <= 0)
      Console.Write(arraytwo[i,j] + " ");

      else Console.Write(arraytwo[i,j] + " ");
    }
    Console.WriteLine();
  }
}