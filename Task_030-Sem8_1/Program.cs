/* ==============================================================
Задайте двумерный массив. Напишите программу,  
которая поменяет местами первую и последнюю строку массива. 
================================================================*/


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


// метод замены местами первой и последней строки 

int[,] ChangeRow(int[,] array)
{
    int temp = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int i = 0;
        for (i = 0; i < array.GetLength(0); i++)
        {
            temp = array[0, j];
            array[0, j] = array[(array.GetLength(0) - 1), j];
            array[(array.GetLength(0) - 1), j] = temp;
        }
    }
    return array;
}



int[,] arrayBivariate = FillArrayBivariate(3, 8);
PrintColorArrayBivariate(arrayBivariate);
Console.WriteLine();

Console.WriteLine("Массив с поменяными местами первой и последней строками");
ChangeRow(arrayBivariate);
PrintColorArrayBivariate(arrayBivariate);

Console.WriteLine();
