/* ======================================================================
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
======================================================================= */

int length = 10;
int minPoint = 100;
int maxPoint = 1001;

// метод заполнения массива случайными элементами
int[] FillArray(int minPoint, int maxPoint)
{
    System.Random numberSintezator = new Random();
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = numberSintezator.Next(minPoint, maxPoint);
    }
    return array;
}

// матод печати массива 
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

// метод пузырьковаЯ сортировка 
int[] BubbleSotr(int[] array)
{
    //int[] outArray = new int[array.Length];
    for (int i = 0; i < (array.Length - i+1); i++)
    {
        int j = 0;
        int temp = 0; // временная переменная. для обмена 
        for (j = 0; j < array.Length - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                temp = array[j + 1];
                array[j + 1] = array[j];
                array[j] = temp;
            }

        }
        // // смотрю количество прогонов. Вроде нет лишних ходов
        // PrintArray(array);
        // Console.WriteLine();
    }
    return array;
}

// Метод поиска количество четных чисел в массиве 
int EvenCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}


int[] bufArray = FillArray(minPoint, maxPoint);
PrintArray(bufArray);
Console.WriteLine();
bufArray = BubbleSotr(bufArray);
PrintArray(bufArray);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве: {EvenCount(bufArray)}");


