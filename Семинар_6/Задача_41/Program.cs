// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] Enter(int M)
{
    int[] array = new int[M];
    Console.WriteLine("Введите цифру:");
    for(int i = 0; i < M; i++)
    {
        int num = int.Parse(Console.ReadLine());
        array[i] = num;
    }
    return array;
}

int Count(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

Console.WriteLine("Введите длину массива:");
int M = int.Parse(Console.ReadLine());

//Console.WriteLine(String.Join(" ", Enter(M)));

Console.WriteLine("Результат: " + Count(Enter(M)));