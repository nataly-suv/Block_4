/* =============================================
Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти
элементы на их квадраты.
============================================== */


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


// метод замены элементов на четных позициях на их квадраты 
int[,] SquareElement(int[,] array)
{
    int[,] outArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < outArray.GetLength(0); i++)
    {
        int j = 0;
        for (j = 0; j < outArray.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                outArray[i, j] = array[i, j] * array[i, j];
            }
            else outArray[i, j] = array[i, j];
        }
    }
    return outArray;
}


// метод замены элементов на четных позициях на их квадраты
// идем по четным строкам и столбцам
void SquareElementVersion2(ref int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        int j = 0;
        for (j = 0; j < array.GetLength(1); j += 2)
        {
            array[i, j] = array[i, j] * array[i, j];
        }
    }
}


int[,] arrayBivariate = FillArrayBivariate(3, 5);
PrintMultiColorArrayBivariate(arrayBivariate);
Console.WriteLine();

DateTime d = DateTime.Now; // точка отсчета для измерения времени
int[,] newArrayBivariate = SquareElement(arrayBivariate);
PrintMultiColorArrayBivariate(newArrayBivariate);
Console.WriteLine(DateTime.Now - d); // Измеряем время выполнения алгоритма
Console.WriteLine();

d = DateTime.Now; // точка отсчета для измерения времени
SquareElementVersion2(ref arrayBivariate);
PrintMultiColorArrayBivariate(arrayBivariate);
Console.WriteLine(DateTime.Now - d); // Измеряем время выполнения алгоритма