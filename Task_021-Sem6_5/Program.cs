/* ==============================================
Напишите программу, которая будет создавать
копию заданного одномерного массива с помощью
поэлементного копирования
=============================================== */ 

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

// первый метод копирования 
int[] CopyArray(int[] array)
{
    int[] newArray = new int [array.Length];
    for (int i=0; i< newArray.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}


// метод копирования через встроенный метод 
int[] CopyMethodArray (int[] array)
{
    int[] newArray = new int[array.Length];
    array.CopyTo(newArray, 0);
    //                     С какого индекса начать копирование 
    return newArray;
}


// универсальный метод (не зависит от типа данных)
object [] CopyObjectArray (params object [] array)
{
    object [] newArray = new object [array.Length];
    array.CopyTo(newArray, 0);
    //                     С какого индекса начать копирование 
    return newArray;
}



Console.WriteLine ("Сгенерированный массив: ");
int[] bufArray = FillArray();
PrintArray(bufArray);

Console.WriteLine ("Скопированный массив: ");
PrintArray(CopyArray(bufArray));

Console.WriteLine ("Скопированный массив через встроенный метод: ");
PrintArray(CopyMethodArray(bufArray));

// Console.WriteLine ("Скопированный массив через универсальный метод: ");
// int[] resultArray =  ConvertAll<object,int> (CopyObjectArray (bufArray), Converter<object,int>);
// PrintArray(resultArray);

//Cast<int>().ToArray()
//Convert.ToInt32(CopyObjectArray(bufArray))
//(int[])CopyObjectArray(bufArray);
// Convert.ToChar

//int[] outArray = (int[])CopyObjectArray(bufArray);

// public static TOutput[] ConvertAll<TInput,TOutput> (TInput[] array, Converter<TInput,TOutput> converter)
// ConvertAll<object,int> (CopyObjectArray (bufArray), Converter<object,int> converter)
// (int[])al.ToArray(typeof(int));