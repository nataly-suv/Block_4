// Заполнить массив из 8 элементов, случайными элементами 0 и 1

System.Random numberSintezator = new Random();

void Variant1()
{
    int i = 0;
    while (i<7)
    {
        Console.Write($"{numberSintezator.Next(0,2)}, ");
        i++;
    }
}

Console.Write("[");
Variant1();
Console.Write($"{numberSintezator.Next(0,2)}");
Console.Write("]");
