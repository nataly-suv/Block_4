/*===========================================
Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в
массиве.
===========================================*/

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
    Console.WriteLine();
}

// метод поиска числа в массиве 
bool CalculateTask(int[] array, int searchNumber)
{
    bool searchResult = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == searchNumber)
        {
            searchResult = true;
            break;
        }
    }
    return searchResult;
}

Console.Write("Введите число:" );
int inNumber = Convert.ToInt32(Console.ReadLine());
int[] bufferArray = FillArray();
PrintArray(bufferArray);
// bool result = CalculateTask(bufferArray, inNumber);
// Console.WriteLine(result);

Console.WriteLine(CalculateTask(bufferArray, inNumber));