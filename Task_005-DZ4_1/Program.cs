/* Программа, ктоорая принимает 2 числа: A и B. 
   И возводит число А в степень В 
*/

// Метод 1 для возведения в степень 
int Сalculat1(int x, int y)
{
    int z = (int)Math.Pow(x, y);
    return z;
}

// Метод 2 для возведения в степень
int Calculat2(int x, int y)
{
    int temp = 1;
    for (int i = 1; i <= y; i++)
    {
        temp = temp * x;
    }
    return temp;
}

// метод вывода на экран
void Print(int x)
{
    Console.WriteLine($"Число А, возведенное в степень В равно: {x}");
}

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int mult1 = Сalculat1(a, b);  // вызываю первый метод
Print(mult1);        // метод вывода на экран

int mult2= Calculat2(a,b);   // вызываю второй метод
Print (mult2);  // метод вывода на экран




