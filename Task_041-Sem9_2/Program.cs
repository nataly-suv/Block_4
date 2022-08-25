/* =========================================================
Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
===========================================================*/



// метод считывания данных
int ReadData(string line)
{
    Console.Write(line);
    return Convert.ToInt32(Console.ReadLine());
}

// метод вывода натуральных числе от m до n (рукурсия) 
void NaturalNamberPrinter(int m, int n)
{
    // m-1 - чтобы напечаталась последняя цифра 
    if (m - 1 == n) return;
    Console.Write(m + " ");
    NaturalNamberPrinter(m + 1, n);
}



int numberM = ReadData("Задайте число M: ");
int numberN = ReadData("Задайте число N: ");

if (numberM < numberN)
    NaturalNamberPrinter(numberM, numberN);
else
    NaturalNamberPrinter(numberN, numberM);
