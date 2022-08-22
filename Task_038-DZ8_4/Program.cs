/*=======================================================================
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента. Массив размером 2 x 2 x 2
========================================================================*/

int countRow = 2;
int countCalumn = 4;
int countWidth = 3;

// счетчик для массива случайных чисел (длина массива)
int quantityNumbers = countRow * countCalumn * countWidth;
// одномерный массив случайных неповторяющихся чисел 
int[] nonRepeatingNumbersAray = NonRepeatingNumbersAray(quantityNumbers);
// трехмерный массив случайных неповторяющихся чисел
int[,,] arrayThree = FillArrayThree(countRow, countCalumn, countWidth, nonRepeatingNumbersAray);
PrintColorArrayBivariate(arrayThree);


// метод генерации случайных неповторяющихся чисел в одномерном массиве
int[] NonRepeatingNumbersAray(int count) // count - длина массива 
{
    int[] outArray = new int[count];
    System.Random numberSintezator = new System.Random();
    outArray[0] = numberSintezator.Next(0, count);
    for (int i = 1; i < outArray.Length;)
    {
        int num = numberSintezator.Next(0, count); // генерирую элемент
        int j;
        // поиск совпадения среди заполненных элементов
        for (j = 0; j < i; j++)
        {
            if (num == outArray[j]) // проверяю есть ли совпадение по элементу
                break; // совпадение найдено, элемент не подходит. Выходим из цикла
        }
        if (j == i)
        {
            outArray[i] = num; // Совпадение не нейдено. Сохраняем элемент в массив
            i++;
        }
    }
    return outArray;
}

// метод заполнения трехмерного массива на основе одномерного массива случайных неповторяющихся чисел
int[,,] FillArrayThree(int countRow, int countCalumn, int countWidth, int[] array)
{
    int m=0; // счетчик для одномерного массива случайных неповторяющихся чисел
    int[,,] outArray = new int[countRow, countCalumn, countWidth];
    for (int i = 0; i < countRow; i++)
    {
        int j = 0;
        for (j = 0; j < countCalumn; j++)
        {
            int k = 0;
            for (k = 0; k < countWidth; k++)
            {
                outArray[i, j, k] = array[m];
                m++;
            }

        }
    }
return outArray;
}

// метод печати цветного трехмерного массива (в один цвет)
void PrintColorArrayBivariate(int[,,] array)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int j = 0;
        for (j = 0; j < array.GetLength(1); j++)
        {
            int k = 0;
            for (k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.ResetColor();
}


