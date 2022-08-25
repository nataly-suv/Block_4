/* =================================================================
Задайте значение N. 
Напишите программу, которая выведет все натуральные числа от N до 1
==================================================================*/
int count = 1;

// метод считывания данных
int ReadData(string line)
{
    Console.Write(line);
    return Convert.ToInt32(Console.ReadLine());
}


// метод вывода ряда от N до 1 (рекурсия)
void ReverseRow(int count, int number)
{
    if (count > number) return; // условие остановки рекурсии 
    else
    {        
        // печатает ход рекурсии 
        Console.WriteLine(count);
        // метод вызывает сам себя, но с  увеличением счетчика
        ReverseRow(count + 1, number);
        Console.Write( count + " ");
    }
}


int inputNumber = ReadData("Задайте число: ");
ReverseRow(count, inputNumber);

