/* =========================================
Напишите программу замены элементов массива:
положительные элементы замените на
соответствующие отрицательные, и наоборот.
==========================================*/
int length = 20;

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
}

// Метод замены + элементов на - элемеyты и наоборот
int[] Calculate(int[] array)
{
    int[] outArray = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        outArray[i] = array[i] * (-1);
    }
    return outArray;
}

// метод с инверсией (работает быстрее)
int[] InverArrayTilda(int[] array)
{
    int i = 0;
    while (i < array.Length)
    {
        array[i] = (~array[i]) + 1;
        i++;
    }
    return array;
}



// метод для программы 
void Result()
{
    int[] buferArray = FillArray();
    PrintArray(buferArray);
    Console.WriteLine();
    int[] resultArray = Calculate(buferArray);
    PrintArray(resultArray);

    Console.WriteLine();
    resultArray= InverArrayTilda(buferArray);
    PrintArray(resultArray);
}

Result();

