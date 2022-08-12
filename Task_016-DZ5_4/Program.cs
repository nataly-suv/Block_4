/* ===========================================================
Cортировка массива методом пузырька вставки и методом подсчета
=============================================================*/

int length = 10;

// метод заполнения массива 
int[] FillArray()
{
    System.Random numberSintezator = new Random();
    int[] outArray = new int[length];
    for (int i = 0; i < outArray.Length; i++)
    {
        outArray[i] = numberSintezator.Next(100, 1000);
    }
    return outArray;
}

// метод печати массива 
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Метод сотрировки - пузырек 
int[] BubbleSort(int[] array)
/* Здесь нужно последовательно 
сравнивать значения соседних элементов и менять числа местами,
если предыдущее оказывается больше последующего */
{
    for (int i = 0; i < (array.Length - i + 1); i++)
    {
        int j = 0;
        int temp = 0;
        for (j = 0; j < (array.Length - 1); j++)
        {
            if (array[j] > array[j + 1])
            {
                temp = array[j + 1];
                array[j + 1] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
}

// Метод сортировки методом вставки 
int[] InsertSort(int[] array)
{
    /* алгоритм сортировки, в котором элементы 
    входной последовательности просматриваются по одному, 
    и каждый новый поступивший элемент размещается в 
    подходящее место среди ранее упорядоченных элементов. 
    Перемещаем в начало */

    for (int i = 1; i < array.Length; i++)
    {
        int temp = 0;
        for (int j = i; j < array.Length; j--)
        {
            if (array[j] < array[j - 1])
            {
                temp = array[j - 1];
                array[j - 1] = array[j];
                array[j] = temp;
            }
            else
                break;
        }
    }
    return array;
}



int[] bufArray = FillArray();
Console.WriteLine("исходный массив:");
PrintArray(bufArray);

DateTime time1 = DateTime.Now;
Console.WriteLine("метод сортировки пузырьком:");
PrintArray(BubbleSort(bufArray));
Console.WriteLine(DateTime.Now-time1);

DateTime time2 = DateTime.Now;
Console.WriteLine("метод сортировки методом вставки:");
PrintArray(InsertSort(bufArray));
Console.WriteLine(DateTime.Now-time2);