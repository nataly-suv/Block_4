/*==========================================================
Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных.
==========================================================*/



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
            outArray[i, j] = numberSintezator.Next(0, 10);

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


// метод составления частотного словаря
int[] FrequencyDictionary(int[,] array, int alphabetLength)
{
    int[] outArray = new int[alphabetLength];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int j = 0;
        for (j = 0; j < array.GetLength(1); j++)
        {
            //Собираем частоту появления элементов
            outArray[array[i, j]]++; 
        }
    }
    return outArray;
}




int[,] arrayBivariate = FillArrayBivariate(3, 5);
Console.WriteLine("Исходный массив");
PrintColorArrayBivariate(arrayBivariate);
Console.WriteLine();

Console.WriteLine("Частотный словарь");
int[] frequency = FrequencyDictionary(arrayBivariate, 10);
PrintArray(frequency);





