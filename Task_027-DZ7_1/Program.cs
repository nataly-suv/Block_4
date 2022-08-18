/* ==================================================================================
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
* При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)
=================================================================================== */

// метод заполнения двумерного массива вещественными числами
double[,] FillDoubleArrayBivariate(int countRow, int countCalumn)
{
    double[,] outArray = new double[countRow, countCalumn];
    System.Random numberSintezator1 = new System.Random(); // для генерации вещественного числа
    System.Random numberSintezator2 = new System.Random(); // для генерации целого числа
    for (int i = 0; i < countRow; i++)
    {
        int j = 0;
        for (j = 0; j < countCalumn; j++)
        {
            outArray[i, j] = Math.Round(numberSintezator1.NextDouble() * numberSintezator2.Next(0, 100), 4);
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


//метод печати цветного массива (разноцветный)
void PrintMultiColorArrayBivariate(double[,] array)
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
            Console.Write(array[i, j] + "\t");   //Console.Write($"{array[i, j]} \t");
            // сбрасываем настройки консоли
            Console.ResetColor();
        }
        Console.WriteLine();
    }
    // скидываем цвет консоли
    Console.ResetColor();
}

// метод печати разноцветных символов
string[,] ColorStringArray(double[,] array)
{
    // создаю строковый массив и перебираем его
    string[,] outArray = new string[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int j = 0;
        for (j = 0; j < array.GetLength(1); j++)
        {
            outArray[i, j] = Convert.ToString(array[i, j]);
            // создаю временную строку, чтобы перекрашивать отдельные символы
            string temp = outArray[i, j];
            // перебираю символы во временной строке и перекрашиваю их
            for (var k = 0; k < temp.Length; k++)
            {           
                Console.ForegroundColor = col[new System.Random().Next(0, 16)];
                Console.Write(temp[k]);
                Console.ResetColor();
            }
            Console.Write("\t");
        }
        Console.WriteLine();
    }
    return outArray;
}

double[,] arrayDoubleBivariate = FillDoubleArrayBivariate(5, 5);
PrintMultiColorArrayBivariate(arrayDoubleBivariate);
Console.WriteLine();

ColorStringArray(arrayDoubleBivariate);


