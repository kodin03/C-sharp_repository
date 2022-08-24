Console.WriteLine("Введите любое целое число:");
int even = 0;
int num = int.Parse(Console.ReadLine());
for (int i = 1; i < num; i++)
{
    if (i % 2 == 0) 
    {
        even = i;
        Console.Write(even + " ");
    }
    else continue;
}

