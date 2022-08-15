/* =================================================
Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Fn=F(n-1)+ F(n-2)
================================================= */

Console.Write("Введите кол-во чисел в ряде Фибоначи: ");
int inNum = Convert.ToInt32(Console.ReadLine());

int[] RowFibonachi(int num)
{
    int[] array = new int[num];
    if (array.Length == 1) array[0] = 0;
    else if (array.Length == 2)
    {
        array[0] = 0;
        array[1] = 1;
    }
    else
    {
        for (int i = 2; i < array.Length; i++)
        {
            array[0] = 0;
            array[1] = 1;
            array[i] = array[i-1] + array[i-2];

        }
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


int[] rowFib = RowFibonachi(inNum);
PrintArray(rowFib);


