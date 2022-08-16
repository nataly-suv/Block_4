/* ====================================
Задайте двумерный массив размером m×n,
заполненный случайными целыми числами.
===================================== */

int countRow = 3;
int countCalumn = 7;

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
            outArray[i, j] = numberSintezator.Next(-9, 10);

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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


// метод печати цветного массива (в один цвет)
void PrintColorArrayBivariate(int[,] array)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    // длина строки. Для строк указывается измерение - 0 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int j = 0;
        // длина столбца. Для столбцов указывается измерение - 1
        for (j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    // скидываем цвет консоли
    Console.ResetColor();
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
            Console.ForegroundColor = col[new System.Random().Next(0,16)];
            Console.Write($"{array[i, j]} ");
            // сбрасываем настройки консоли
            Console.ResetColor();
        }
        Console.WriteLine();
    }
    // скидываем цвет консоли
    Console.ResetColor();
}



int[,] arrayBivariate = FillArrayBivariate(countRow, countCalumn);
PrintArrayBivariate(arrayBivariate);
Console.WriteLine();

PrintColorArrayBivariate(arrayBivariate);
Console.WriteLine();

PrintMultiColorArrayBivariate(arrayBivariate);