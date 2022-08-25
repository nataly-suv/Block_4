/* ======================================================
Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.
=========================================================*/
int sum = 0;

// метод считывания данных
int ReadData(string line)
{
    Console.Write(line);
    return Convert.ToInt32(Console.ReadLine());
}


// метод суммы натуральных числе от m до n (рукурсия) 
void SumRow(int m, int n)
{
    if (m - 1 == n) Console.WriteLine(sum);
    else
    {
        sum = sum + m;
        SumRow(m + 1, n);
    }
}


int numberM = ReadData("Задайте число M: ");
int numberN = ReadData("Задайте число N: ");

if (numberM < numberN)
    SumRow(numberM, numberN);
else
    SumRow(numberN, numberM);
