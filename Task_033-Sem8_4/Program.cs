/* ==========================================================
Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых 
расположен наименьший элемент массива.
========================================================== */


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
    Console.ForegroundColor = ConsoleColor.Green;
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


// Метод печати одномерного массива 
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


// метод поиска координат минимального элемента
int[] FindMinElement(int[,] array)
{
    int[] outArray = new int[] { 0, 0 };
    int minElement = array[0, 0];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minElement)
            {
                minElement = array[i, j];
                outArray[0] = i;
                outArray[1] = j;
            }
        }
    }
    return outArray;
}


// метод удаления строки и слобца, с хаданным индексом
int[,] ModificationArray(int[,] array, int row, int column)
{
    int[,] outArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0; int m = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int j = 0; m = 0;
        for (j = 0; j < array.GetLength(1); j++)
        {
            if (i != row && j != column)
            {
                outArray[k, m] = array[i, j];
            }
            if (j != column) m++;
        }
        if (i != row) k++;
    }
    return outArray;
}



int[,] arrayBivariate = FillArrayBivariate(4, 8);
Console.WriteLine("Исходный массив");
PrintColorArrayBivariate(arrayBivariate);
Console.WriteLine();

Console.WriteLine("Координаты минимального элемнета массива");
int[] coordArray = FindMinElement(arrayBivariate);
PrintArray(coordArray);
Console.WriteLine();

Console.WriteLine("Массив, с удаленными строкой и столбцом");
int[,] newArray = ModificationArray(arrayBivariate, coordArray[0], coordArray[1]);
PrintColorArrayBivariate(newArray);
Console.WriteLine();

