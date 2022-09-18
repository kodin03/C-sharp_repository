/* Написать функцию Sqrt(x) - квадратного корня, которая принимает на вход целочисленное значение x и возвращает 
целую часть квадратного корня от введенного числа. */

int num = 0;
int dec = 0;
int units = 0;
int div = 0;
int sum = 0;
int result = 0;

void Sqrt(int x)
{
    if (x <= 100)
    {
       for (int i = 1; i <= 10; i++)
       {
        if ((i*i) <= x) result = i;
       }   
       Console.WriteLine("Корень числа: " + result);
    }
    else if (x > 100 && x < 10000)
    {
        for (int i = 1; i <= 10; i++)
       {
        if ((i*i) <= x / 100) dec = i;
       } 
       
       num = ((x / 100) - dec*dec) * 100 + (x % 100);
       div = num / 10; 
       div = div / (2*dec); 
       for(int i = div; i > 0; i--) {
        sum = (2*dec*10) + i; 
        result = sum * i;      
       if (result <= num) 
       {
        units = i;
        break;
       } 
       } 
       Console.WriteLine("Корень числа: " + dec + units);
       
    }
    else if (x == 10000) Console.WriteLine("Корень числа: 100");  
}

Console.WriteLine("Введите число:");
int x = int.Parse(Console.ReadLine());
Sqrt(x);

