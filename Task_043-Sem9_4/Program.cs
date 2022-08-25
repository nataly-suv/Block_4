/* ======================================================
Напишите программу, которая на вход принимает два числа A и B,
и возводит число А в целую степень B с помощью рекурсии.
=========================================================*/


// метод считывания данных
int ReadData(string line)
{
    Console.Write(line);
    return Convert.ToInt32(Console.ReadLine());
}


// Рекурсивный метод возведения в степень (метод в лоб)
int PowNumberVar1(int a, int b)
{
    if (b == 1) return a;
    return a * PowNumberVar1(a, b - 1);
}


// Рекурсивный метод возведения в степень (с учетом четности степени)
int PowNumberVar2(int a, int b)
{
    if (b == 2)
    {
        return a * a;
    }
    if (b == 1)
    {
        return a;
    }
    if (b % 2 == 0)
    {
        return PowNumberVar2(a, b / 2) * PowNumberVar2(a, b / 2);
    }
    else
    {
        return PowNumberVar2(a, b / 2) * PowNumberVar2(a, (b / 2) + 1);
    }
}


int numberA = ReadData("Задайте число A: ");
int numberB = ReadData("Задайте число B: ");

DateTime d = DateTime.Now;
int resultVar1 = PowNumberVar1(numberA, numberB);
Console.WriteLine(DateTime.Now - d);
Console.WriteLine(resultVar1);


d = DateTime.Now;
int resultVar2 = PowNumberVar2(numberA, numberB);
Console.WriteLine(DateTime.Now - d);
Console.WriteLine(resultVar2);

d = DateTime.Now;
double resultVar3 = Math.Pow(numberA, numberB);
Console.WriteLine(DateTime.Now - d);
Console.WriteLine(resultVar3);


