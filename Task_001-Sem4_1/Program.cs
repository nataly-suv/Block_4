// Программа примимает число и выдает сумму от [1, N]

Console.Write ("Введите положительное число: ");
long inNum = Convert.ToInt64 (Console.ReadLine());

int t; // для подсчета веремени 

void VarianSimple ()
{
    long sum=0;
    for (int i=1; i <= inNum; i++)
    {
        sum+=i;
    }
    Console.WriteLine ($"1 вариант. Сумма равна {sum}");
}

void VariantGaysa()
{
    long sum = (inNum*(inNum+1))/2;
    Console.WriteLine($"Вариант по Гаусу. Сумма равна {sum}");
}

Console.Clear(); 
Console.WriteLine($"Введенное число равно {inNum}");

t= Environment.TickCount;  // текущий отсчет по времени
VarianSimple();
Console.WriteLine ("время 1: {0} ms", Environment.TickCount-t);

t= Environment.TickCount; // текущий отсчет по времени
VariantGaysa();
Console.WriteLine ("время 2: {0} ms", Environment.TickCount-t);

Console.WriteLine();
