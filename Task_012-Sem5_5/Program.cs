/* ============================================
Найдите произведение пар чисел в одномерном
массиве. Парой считаем первый и последний
элемент, второй и предпоследний и т.д. Результат
запишите в новом массиве.
==============================================*/

int length = 6;

// Метод заполнения массива 
int[] FillArray()
{
    int[] outArray = new int[length];
    System.Random numberSintezator = new System.Random();
    for (int i = 0; i < outArray.Length; i++)
    {
        outArray[i] = numberSintezator.Next(-9, 10);
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
    Console.WriteLine();
}

// создание массива из пар входногом ассива
int[] CalculateTask(int[] array)
{
    int[] resultArray = new int[array.Length / 2];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = array[i] * array[array.Length - 1 - i];
    }
    return resultArray;
}


int[] buferArray = FillArray();
PrintArray(buferArray);
int[] resultArray = CalculateTask(buferArray);
PrintArray(resultArray);

