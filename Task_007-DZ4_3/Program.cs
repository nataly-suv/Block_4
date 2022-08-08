// программа, которая задает массив из 8 элементов и выводит их на экран

// метод заполнения массива 
void FillArray(int[] array)
{
    System.Random numbers = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = numbers.Next(10, 101);
    }
}

// Метод печати массива
void Print (int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


int[] massiv = new int[8];
FillArray(massiv);
Print(massiv);

 