// Определить количество цифр в числе 

Console.Write("Введите число: ");
string inNumber = Console.ReadLine() ?? "";

// поиск через массив
int Variant1()
{
    char[] array = inNumber.ToCharArray();
    int arrayLength = array.Length;
    return arrayLength;
}

// поиск через цикл
int Variant2()
{
    int number = int.Parse(inNumber);
    int numberLength = 0;
    int count = 1;
    while (count <= number)
    {
        count *= 10;
        numberLength++;
    }
    return numberLength;
}

// поиск через логарифм 
int Variant3()

{
    int number = int.Parse(inNumber);
    int numberLength = (int)Math.Log10(number) + 1;
    return numberLength;
}

DateTime timePoint = DateTime.Now; 
Console.WriteLine($"1. Колличество цифр в числе: {Variant1()}");
Console.WriteLine("    Время первого варианта " + (DateTime.Now - timePoint));

Console.WriteLine($"2. Колличество цифр в числе: {Variant2()}");
Console.WriteLine("    Время второго варианта " + (DateTime.Now - timePoint));

Console.WriteLine($"3. Колличество цифр в числе: {Variant3()}"); 
Console.WriteLine("    Время третьего варианта " + (DateTime.Now - timePoint));