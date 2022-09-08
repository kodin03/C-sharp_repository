// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] GetArray(int size) 
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
} 

double Diff(double[] array)
{
    double min = 1000.0;
    double max = 0.0;
    double diff = 0;
    foreach(var el in array)
    {
        if (el < min) min = el;
        if (el > max) max = el;
    }
    diff = max - min;
    return diff;
}


Console.WriteLine("Введите длину массива:");
int lenght = int.Parse(Console.ReadLine());

double[] res = GetArray(lenght);

Console.WriteLine(String.Join(" ", res));
Console.WriteLine("Разница: " + Diff(res));