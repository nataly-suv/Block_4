// произведение от 1 до N 

Console.Write ("Введите число: ");
int inNumber = Convert.ToInt32 (Console.ReadLine());

void Multi(int x)
{
    long y = 1;
    for (int i = 1; i <= x; i++)
    {
        y *=i;
    }
    Console.WriteLine("1. Произведенеи равно: " + y);
}


Multi(inNumber); 

// // через рекурсию 
// int Factorial(int n)
// {
//     if (n == 1) return 1;
 
//     return n * Factorial(n - 1);
// }
// Console.WriteLine (Factorial(inNumber));