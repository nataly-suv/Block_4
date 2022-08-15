/* ============================================
Напишите программу, которая будет
преобразовывать десятичное число в двоичное.
============================================== */

Console.Write("Введите число: ");


// певый способ
Console.WriteLine(Convert.ToString(Convert.ToInt32(Console.ReadLine()), 2));

/*
int а = Convert.ToInt32(Console.ReadLine()) - считываем с консоли число
string result = Convert.ToString (a, 2) - переволим в строку и сразу переводим в 2-ую систему. 
Console.WriteLine (result) - выводим результат
Можно вместо 2 поставить 8 (восьмеричная система исчисления)
или 16 (шестнадцатиричная система исчисления). 
*/

// второй способ 

Console.Write("Введите десятичное число: ");
string numbe1 = Console.ReadLine();
int decemalNumber = ReadDecemalNumber();
PrintAnswer(BinaryConverter(decemalNumber));

int ReadDecemalNumber()
{
    return int.Parse(numbe1 ?? "");
}

string BinaryConverter(int num)
{
    string bin = "";
    while (num > 0)
    {
        if (num % 2 == 1)
        {
            bin = "1" + bin;
        }
        else
        {
            bin = "0" + bin;
        }
        num /= 2;
    }
    return bin;
}

void PrintAnswer(string answer)
{
    Console.WriteLine("Введенное число в двоичном виде: " + answer);
}