/*=======================================================================
Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
========================================================================*/

// прямое перемножение. строки на строки 


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

// Метод прямого перемножения массивов 
int[,] MultiplicationArray(int[,] array_1, int[,] array_2)
{
    int[,] outArray = new int[array_1.GetLength(0), array_1.GetLength(1)];
    // проверка, что массивы совпадают
    if (array_1.GetLength(0) == array_2.GetLength(0) && array_1.GetLength(1) == array_2.GetLength(1))
    {
        for (int i = 0; i < outArray.GetLength(0); i++)
        {
            int j = 0;
            for (j = 0; j < outArray.GetLength(1); j++)
            {
                outArray[i, j] = array_1[i, j] * array_2[i, j];
            }
        }
    }
    else Console.WriteLine("Массивы перемножить нельзя");
    return outArray;
}

Console.WriteLine("Первый массив");
int[,] array1 = FillArrayBivariate(3, 5);
PrintColorArrayBivariate(array1);
Console.WriteLine();

Console.WriteLine("Второй массив");
int[,] array2 = FillArrayBivariate(3, 5);
PrintColorArrayBivariate(array2);
Console.WriteLine();

Console.WriteLine("Итоговый массив");
PrintColorArrayBivariate(MultiplicationArray(array1, array2));




