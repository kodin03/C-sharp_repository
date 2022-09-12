// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Без массива

string s2 = String.Empty;

string Enter(int M)
{
    string s = String.Empty;
    Console.WriteLine("Введите цифру:");
    for(int i = 0; i < M; i++)
    {
        int num = int.Parse(Console.ReadLine());
        string s1 = Convert.ToString(num);
        s = s + s1;
    }
    return s;
}

int Count(string s)
{
    int count = 0;
    int num = Convert.ToInt32(s);
    for(int i = 0; i < s.Length; i++)
    {
        if (num % 10 > 0) 
        {
            count++;
            num /= 10;
        }
        else num /= 10;
    }
    return count;
}

Console.WriteLine("Введите длину массива:");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Результат: " + Count(Enter(M)));