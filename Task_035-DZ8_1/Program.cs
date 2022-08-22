/*=======================================================================
Задайте двумерный массив. Напишите программу, 
которая упорядочит по возрастанию элементы каждой строки двумерного массива.
========================================================================*/


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


// метод сортировки элементов строк по возростанию  
int[,] RiseRow(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int j = 1;
        for (j = 1; j < array.GetLength(1); j++)
        {
            int k = 0;
            int temp = 0;
            // алгоритм сортировки строки методом вставками 
            for (k = j; k > 0; k--)
            {
                if (array[i, k] < array[i, k - 1])
                {
                    temp = array[i, k - 1];
                    array[i, k - 1] = array[i, k];
                    array[i, k] = temp;
                }
                else
                    break;
            }
        }
    }
    return array;
}


int[,] arrayBivariate = FillArrayBivariate(5, 8);
PrintColorArrayBivariate(arrayBivariate);
Console.WriteLine();

Console.WriteLine("Массив c упорядоченными элементами (метод вставками)");
PrintColorArrayBivariate(RiseRow(arrayBivariate));
Console.WriteLine();

