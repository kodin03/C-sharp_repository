/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве. */

int[] GetArray(int size, int min, int max) 
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
} 

int Count(int[] array)
{
    int count = 0;
    foreach(var item in array)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}

Console.WriteLine("Введите длину массива:");
int lenght = int.Parse(Console.ReadLine());

int[] res = GetArray(lenght, 100, 999);
Console.WriteLine(String.Join(" ", res));

Console.WriteLine("Количество четных чисел в массиве: " + Count(res));