/*===========================================================
Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов
============================================================ */

// метод заполнения двумерного массива 
int[,] FillArrayBivariate(int countRow, int countCalumn)
{
    int[,] outArray = new int[countRow, countCalumn];
    System.Random numberSintezator = new System.Random();
    for (int i = 0; i < countRow; i++)
    {
        int j = 0;
        for (j = 0; j < countCalumn; j++)
        {
            outArray[i, j] = numberSintezator.Next(0, 100);

        }
    }
    return outArray;
}

// метод печати цветного массива (в один цвет)
void PrintColorArrayBivariate(int[,] array)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    //  длина строки. Для строк указывается измерение - 0 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int j = 0;
        // длина столбца. Для столбцов указывается измерение - 1
        for (j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    // скидываем цвет консоли
    Console.ResetColor();
}

// метод нахождения суммы элементов в строках 
int[] SummaRow(int[,] array)
{
    // массив для хранения сумы элементов в строке
    int[] outArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int j = 0;
        int sum = 0;
        for (j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
            outArray[i] = sum;
        }
    }
    return outArray;
}

// Метод печати одномерного массива 
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// метод поиска минимального в массиве 
void MiminumArray(int[] array)
{
    int min = array[0];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            count = i;
        }

    }
    Console.WriteLine($"Минимальная сумма элементов находится в строке {count} и равна {min}");
}


int[,] arrayBivariate = FillArrayBivariate(5, 3);
PrintColorArrayBivariate(arrayBivariate);
Console.WriteLine();

Console.WriteLine("Сумма элементов по строкам");
PrintArray(SummaRow(arrayBivariate));
Console.WriteLine();

MiminumArray(SummaRow(arrayBivariate));
Console.WriteLine();




