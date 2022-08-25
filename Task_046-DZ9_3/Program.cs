/* =================================================================
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n
m = 2, n = 3 -> A(m,n) = 9 ;  m = 3, n = 2 -> A(m,n) = 29
           _  
          |   n+1,                при m=0
A(m,n) =  |   A(m-1, 1)           при m>0, n=0
          |_  A(m-1, A(m, n-1))   при m>0, n>0
==================================================================*/


// метод считывания данных
int ReadData(string line)
{
    Console.Write(line);
    return Convert.ToInt32(Console.ReadLine());
}

// метод вычисления функции Аккермана 
int FunctionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return FunctionAkkerman(m - 1, 1);
    else return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");

if (m >= 0 && n >= 0)
{
    int result = FunctionAkkerman(m, n);
    Console.WriteLine($"Функция Аккермана = {result}");
}
else Console.WriteLine("Функцию Аккермана вычислить нельзя");