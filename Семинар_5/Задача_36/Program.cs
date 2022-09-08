// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetArray(int size, int min, int max) 
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
} 

int Sum(int[] array)
{
    int sum = 0;
    foreach(var el in array)
    {
        if (el % 2 == 1) sum = sum + el;
    }
    return sum;
}

Console.WriteLine("Введите длину массива:");
int lenght = int.Parse(Console.ReadLine());

int[] res = GetArray(lenght, 1, 20);
Console.WriteLine(String.Join(" ", res));

Console.WriteLine("Сумма нечетных чисел: " + Sum(res));