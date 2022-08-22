/*=======================================================================
Заполните спирально массив 4 на 4.
========================================================================*/
// !!!!!  Работает только на квадратных массивах 

// метод заполнения спирального двумерного массива 
int[,] FillArraySnake(int countRow, int countCalumn)
{
    int quantityElement = countRow * countCalumn;
    int counter = 1;
    int i=0, j=0;
    int[,] outArray = new int[countRow, countCalumn];
    for (counter = 1; counter <= quantityElement; counter++)
    {
        outArray[i, j] = counter;
        if (i <= j + 1 && i + j < outArray.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= outArray.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > outArray.GetLength(1) - 1)
            j--;
        else
            i--;


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


int[,] arraySnake = FillArraySnake(4, 4);
PrintColorArrayBivariate(arraySnake);
Console.WriteLine();


