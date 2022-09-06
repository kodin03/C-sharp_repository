// Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.

Console.WriteLine("Введите высоту елочки:");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++) 
{
    for (int space = n; space > i; space--)
    {
        Console.Write(" ");
    }
    for (int count = 1; count <= i*2 - 1; count++)
    {
        Console.Write("*");
    }
    Console.WriteLine();  
     
}