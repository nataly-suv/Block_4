/* ==========================================
Задайте одномерный массив из 123 случайных
чисел. Найдите количество элементов массива,
значения которых лежат в отрезке [10,99].
============================================*/


int length = 123;

// Метод заполнения массива 
int[] FillArray()
{
    int[] outArray = new int[length];
    System.Random numberSintezator = new System.Random();
    for (int i = 0; i < outArray.Length; i++)
    {
        outArray[i] = numberSintezator.Next(-1000, 1000);
    }
    return outArray;
}

// Метод печати массива 
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

// метод поиска кол-во чисел в отрезке [10, 99]
int CalculateTask(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
            count ++;
    }
    return count;
}


int[] buferArray = FillArray();
PrintArray(buferArray);
Console.WriteLine();
Console.WriteLine($"Кол-во элементов в отрезке[10, 99] равно: {CalculateTask(buferArray)}");


