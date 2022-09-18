// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int sum = 0;
void Sum(int m, int n) {
    if (m <= n)
    {
        sum = sum + m;
        Sum(++m, n);
    }
}

Console.Write("Введите число num1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число num2: ");
int num2 = int.Parse(Console.ReadLine());
Sum(num1, num2);
Console.Write(sum);