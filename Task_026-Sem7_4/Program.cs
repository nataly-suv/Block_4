/* ============================================
Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали 
(синдексами (0,0); (1;1) и т.д.
============================================ */

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
            outArray[i, j] = numberSintezator.Next(0, 50);

        }
    }
    return outArray;
}

//задаем массив цветов 
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

// метод печати цветного массива (разноцветный)
void PrintMultiColorArrayBivariate(int[,] array)
{
    // длина строки. Для строк указывается измерение - 0 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int j = 0;
        // длина столбца. Для столбцов указывается измерение - 1
        for (j = 0; j < array.GetLength(1); j++)
        {
            // выбираем случайный цвет из массива цветов
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write($"{array[i, j]} \t");
            // сбрасываем настройки консоли
            Console.ResetColor();
        }
        Console.WriteLine();
    }
    // скидываем цвет консоли
    Console.ResetColor();
}

// метод нахождения суммы на главной диагонали
int SumDiagonal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int j = 0;
        for (j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + array[i, j];
            }
        }
    }
    return sum;
}

// второй метод нахождения суммы главной диагонали
int SumDiagonalVariant2(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = sum + array[i, i];
    }

    return sum;
}

int[,] arrayBivariate = FillArrayBivariate(5, 5);
PrintMultiColorArrayBivariate(arrayBivariate);
Console.WriteLine();

DateTime d = DateTime.Now; // точка отсчета для измерения времени
Console.WriteLine($"Сумма элементов главной диагонали равна {SumDiagonal(arrayBivariate)}");
Console.WriteLine(DateTime.Now - d); // Измеряем время выполнения алгоритма

d = DateTime.Now; // точка отсчета для измерения времени
Console.WriteLine($"Второй метод. Сумма диагонали равна {SumDiagonalVariant2(arrayBivariate)}");
Console.WriteLine(DateTime.Now - d); // Измеряем время выполнения алгоритма
