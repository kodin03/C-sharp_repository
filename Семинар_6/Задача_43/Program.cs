/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. */


void Point(int b1, int b2, int k1, int k2)
{
    if ((b1 == 0) & (b2 == 0) & (k1 == 0) & (k2 == 0)) Console.WriteLine("Прямые не существуют");
    else if (b1 == b2 && b2 == k1 && k1 == k2) Console.WriteLine("Прямые лежат на одной линии");
    else if (k1 == k2) Console.WriteLine("Прямые никогда не пересекутся");
    else 
    {
        int x = ((b2 - b1) / (k1 - k2));
        int y = k1 * x + b1;
        Console.WriteLine("Прямые пересекутся в точке: -> " + "(" + x + ", " + y + ")"); 
    }
   
}

Console.WriteLine("Введите k1:");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b1:");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k2:");
int k2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b2:");
int b2 = int.Parse(Console.ReadLine());

Point(b1, b2, k1, k2);
