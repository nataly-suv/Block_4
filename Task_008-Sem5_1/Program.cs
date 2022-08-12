/* ==============================================
Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных
элементов массива.
=============================================== */

int posetivSum = 0;
int negativSum = 0;

// метод для заполнения массива 
int[] FillArray()
{
    int[] outArray = new int[12];
    System.Random numberSintexator = new System.Random();
    for (int i = 0; i < 12; i++)
    {
        outArray[i] = numberSintexator.Next(-9, 10);
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
}

// Метод подсчета суммы + и - элементов 
void CalculateTask(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            posetivSum += array[i];
        else
            negativSum += array[i];
    }
}

// метод печати результата 
void PrintResult()
{
    Console.WriteLine();
    Console.WriteLine(posetivSum);
    Console.WriteLine(negativSum);
}

// метод самой программы
void VarianNaive()
{
    int[] bufferArray = FillArray();
    PrintArray(bufferArray);
    CalculateTask(bufferArray);
    PrintResult();
}

VarianNaive();

