/* =================================================================================
Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести  сообщение для пользователя.
===================================================================================*/


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
    Console.ForegroundColor = ConsoleColor.DarkBlue;
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


// метод замены местами строк и столбцов (квадратный массив) 
int[,] ChangeRowColumn(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(0); j++)
        {
            temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
    return array;
}


// метод переворота прямоугольного массива 
int[,] ChangeRowColumnVarint2(int[,] array)
{
    int[,] outArray = new int[array.GetLength(1), array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int j = 0;
        for (j = 0; j < array.GetLength(1); j++)
        {
            outArray[j, i] = array[i, j];            
        }
    }
    return outArray;
}



int[,] arrayBivariate = FillArrayBivariate(3, 3);
Console.WriteLine("Исходный массив");
PrintColorArrayBivariate(arrayBivariate);
Console.WriteLine();

int[,] changeRowColumnVarint2 = ChangeRowColumnVarint2(arrayBivariate);
Console.WriteLine("Метод переворота прямоугольного массива");
PrintColorArrayBivariate(changeRowColumnVarint2);
Console.WriteLine();

Console.WriteLine("Метод переворота квадратного массива");
if (arrayBivariate.GetLength(0) != arrayBivariate.GetLength(1))
{
    Console.WriteLine("Данный массив перевернуть нельзя!");
}
else PrintColorArrayBivariate (ChangeRowColumn(arrayBivariate));    
