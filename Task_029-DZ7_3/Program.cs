/* ========================================================================================
 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
столбце.
=========================================================================================== */


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
ConsoleColor[] col = new ConsoleColor[]
{
    ConsoleColor.Red,ConsoleColor.Blue,ConsoleColor.DarkGreen, ConsoleColor.Yellow,
    ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
    ConsoleColor.DarkMagenta,ConsoleColor.DarkRed, ConsoleColor.DarkYellow,
    ConsoleColor.Gray,ConsoleColor.Cyan,ConsoleColor.Green,
    ConsoleColor.Magenta,ConsoleColor.Black,ConsoleColor.White

};

// метод печати цветного массива (столбцы в разный цвет)
void PrintColorArrayBivariate(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int j = 0;
        for (j = 0; j < array.GetLength(1); j++)
        {
            Console.ForegroundColor = col[j];
            Console.Write(array[i, j] + "\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}


// метод нахождения среднего арифметического в столбцах
double[] AverageArithmeticCalumn(int[,] array)
{
    // создаю одномерный массив для записи ср.арифм. по столбцам
    double[] averageCalumn = new double[array.GetLength(1)];
    // сначала прохожу по столбцам
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int i = 0;
        double sumCalumn = 0;
        // прохожу по стокам и считаю сумму и ср.ариф. в столбце
        for (i = 0; i < array.GetLength(0); i++)
        {
            sumCalumn += array[i, j];
        }
        averageCalumn[j] = Math.Round((sumCalumn / array.GetLength(0)), 2);
    }
    return averageCalumn;
}

// Метод печати одномерного массива 
void Print(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.ForegroundColor = col[i];
        Console.Write(array[i] + "\t");
        Console.ResetColor();
    }
    Console.WriteLine();
}


Console.WriteLine("Все");
int[,] arrayBivariate = FillArrayBivariate(3, 5);
PrintColorArrayBivariate(arrayBivariate);

Console.WriteLine("Среднее арифметическое по столбцам:");
double[] averageCalumn = AverageArithmeticCalumn(arrayBivariate);
Print(averageCalumn);
Console.WriteLine();
