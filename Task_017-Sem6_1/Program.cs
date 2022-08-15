/* =====================================================================
Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
======================================================================= */

int length = 11;

// метод заполнения массива 
int[] FillArray()
{
    System.Random numberSintezator = new Random();
    int[] outArray = new int[length];
    for (int i = 0; i < outArray.Length; i++)
    {
        outArray[i] = numberSintezator.Next(-100, 100);
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


// метод переворота массива 
int[] ReverseArray(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
}


// метод переворота через перезапись в новый массив
int[] ReverseRewriteArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = array[array.Length - 1 - i];
    }
    return newArray;
} 


int[] bufArray = FillArray();
PrintArray(bufArray);

// сначала идет второй метод, иначе они вступают в конфликт. 
Console.WriteLine("Перевернутый массив через перезапись в новый массив");
PrintArray(ReverseRewriteArray(bufArray));

// вызываю первый метод перезаписи
Console.WriteLine("Перевернутый массив");
PrintArray(ReverseArray(bufArray));
