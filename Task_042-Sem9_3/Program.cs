/* ======================================================
Напишите программу, которая 
будет принимать на вход число и возвращать сумму его цифр.
=========================================================*/

// метод считывания данных
int ReadData(string line)
{
    Console.Write(line);
    return Convert.ToInt32(Console.ReadLine());
}


// метод вычисления суммы цмфр в числе (рекурсия)
int SumDigit(int num)
{
    if (num > 0)
        return num % 10 + SumDigit(num / 10);

    else
        return 0;
}


int inputNumber = ReadData("Задайте число: ");
Console.WriteLine(SumDigit(inputNumber));



/* стек 
число: 12345
шаг 1: num % 10 = 5 и в метод положит SumDigit(num / 10)= 1234  out 5
шаг 2: num % 10 = 4 и в метод положит SumDigit(num / 10)= 123 out 4
шаг 3: num % 10 = 3 и в метод положит SumDigit(num / 10)= 12  out 3
шаг 4: num % 10 = 2 и в метод положит SumDigit(num / 10)= 1 out 2
шаг 5: num % 10 = 1 и в метод положит SumDigit(num / 10)= 0    out 1
шаг 6: 0   рекурсия заканчивается
*/
