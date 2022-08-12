/* =====================================================
Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.
====================================================== */

int length = 10;

// массив вещественных чисел
double[] FillArrayDouble()
{
    System.Random numberSintezator = new Random();
    double[] outArray = new double[length];
    for (int i = 0; i < length; i++)
    {
        outArray[i] = numberSintezator.NextDouble();
    }
    return outArray;
}

// печать массива 
void PrintArrayDouble(double[] array)
{
    for (int i = 0; i < length; i++)
    {
        array[i]=Math.Round(array[i] * 100, 3);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// метод поиска разницы между мах и мин
void DifMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < (array.Length - 1); i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    double result = max-min;
    Console.WriteLine("Максимальное число в массвие: " + max);
    Console.WriteLine("Минимальное число в массвие: " + min);
    Console.WriteLine($"Разница между мах и мин: {result}");
}


double[] bufArray = FillArrayDouble();
PrintArrayDouble(bufArray);
DifMaxMin(bufArray);