// Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.

int[] GetArray(int size, int min, int max) 
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
} 

int[] BubbleSort(int[] array)
{
    int num;
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j + 1] > array[j])
            {
                num = array[j + 1];
                array[j + 1] = array[j];
                array[j] = num;
            }
        }
    }
    return array;
}


Console.WriteLine("Введите длину массива:");
int lenght = int.Parse(Console.ReadLine());

int[] res = GetArray(lenght, 1, 99);

Console.WriteLine(String.Join(" ", res));
BubbleSort(res);
Console.WriteLine("Сортировка: ");
for(int i = 0; i < res.Length; i++) 
{
    Console.Write(res[i]);
    Console.Write(" ");
}