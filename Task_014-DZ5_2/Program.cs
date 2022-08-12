/* ====================================================================
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
===================================================================== */

int length = 10;

// метод заполнения массива 
int[] FillArray()
{
    System.Random numberSintezator = new Random();
    int[] outArray = new int[length];
    for (int i = 0; i < outArray.Length; i++)
    {
        outArray[i] = numberSintezator.Next(0,100);
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

// метод подсчета суммы элементов на нечетных позициях
int UnevenIndexSum(int[] array)
{
    int unevenSum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        unevenSum += array[i];
    }
    return unevenSum;
}

// метод поиска одинаковых пар   // выдает ВСЕ!!! одинаковые пары. числа могут повторяться 
void SameCouple(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = (i + 1); j < array.Length; j++)
        {
            if (array[i] == array[j]) 
            Console.WriteLine($"Одинаковая пара чисел: А{i} = {array[i]} и А{j} = {array[j]}");
        }
    }
}


int[] bufArray = FillArray();
PrintArray(bufArray);
Console.WriteLine($"Сумма чисел на нечетных позициях равна: {UnevenIndexSum(bufArray)}");
SameCouple(bufArray);

