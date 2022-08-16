/* ============================================
Задайте двумерный массив размера m на n, каждый
элемент в массиве находится по формуле: Aₘₙ =
m+n. Выведите полученный массив на экран.
=============================================*/

// метод заполнения двумерного массива 
int[,] FillArrayBivariate(int countRow, int countCalumn)
{
    int[,] outArray = new int[countRow, countCalumn];
    for (int i = 0; i < countRow; i++)
    {
        int j = 0;
        for (j = 0; j < countCalumn; j++)
        {
            outArray[i, j] = i + j;

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
            Console.Write($"{array[i, j]} ");
            // сбрасываем настройки консоли
            Console.ResetColor();
        }
        Console.WriteLine();
    }
    // скидываем цвет консоли
    Console.ResetColor();
}


int[,] arrayBivariate = FillArrayBivariate(3, 5);
PrintMultiColorArrayBivariate(arrayBivariate);


