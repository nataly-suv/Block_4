/* ====================================================================================
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание, что такого элемента нет.
* Заполнить числами Фиббоначи и выделить цветом найденную цифру
====================================================================================== */

// метод заполнения двумерного массива числами Фибоначи 
// !!! не работает при количестве столбцов равному 1
int[,] FillArrayBivariateFib(int countRow, int countCalumn)
{
    int[,] outArray = new int[countRow, countCalumn];

    // заполняю первые 2 элемента
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            outArray[0, 0] = 0;
            outArray[0, 1] = 1;
        }
    }

    // заполняю первую  строку
    for (int i = 0; i < 1; i++)
    {
        for (int j = 2; j < countCalumn; j++)
        {
            outArray[i, j] = outArray[i, (j - 1)] + outArray[i, (j - 2)];
        }
    }

    // заполняю остальной массив
    for (int i = 1; i < countRow; i++)
    {
        int j = 0;
        for (j = 0; j < countCalumn; j++)
        {
            if (j < 2)
            {
                outArray[i, 0] = outArray[(i - 1), (countCalumn - 1)] + outArray[(i - 1), (countCalumn - 2)];
                outArray[i, 1] = outArray[i, 0] + outArray[(i - 1), countCalumn - 1];
            }
            else outArray[i, j] = outArray[i, (j - 1)] + outArray[i, (j - 2)];
        }
    }
    return outArray;
}


// метод печати двумерного массива 
void PrintArrayBivariate(int[,] array)
{
    // длина строки. Для строк указывается измерение - 0 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int j = 0;
        // длина столбца. Для столбцов указывается измерение - 1
        for (j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


// Метод нахождения заданного числа в массиве и выдление его цветом
void SerchElement(int[,] array, int serchNumber)
{
    bool proverca = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int j = 0;
        for (j = 0; j < array.GetLength(1); j++)
        {
            if (serchNumber == array[i, j])
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Данное число находится на позиции [{i}, {j}]");
                Console.WriteLine();
                proverca = true;
                Console.ResetColor();
                for (int k = 0; k < array.GetLength(0); k++)
                {
                    int m = 0;
                    for (m = 0; m < array.GetLength(1); m++)
                    {
                        if (serchNumber == array[k, m])
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(array[k, m] + "\t");
                            Console.ResetColor();
                        }
                        else Console.Write(array[k, m] + "\t");
                    }
                    Console.WriteLine();
                }
                break;
            }
        }
    }
    if (proverca == false)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Данного числа нет в массиве");
        Console.ResetColor();
    }
}



int[,] arrayBivariate = FillArrayBivariateFib(4, 6);
PrintArrayBivariate(arrayBivariate);
Console.WriteLine();

Console.Write("Введите число, которое хотите найти в массиве: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
SerchElement(arrayBivariate, inputNumber);
Console.WriteLine();


