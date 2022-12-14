/* =================================================================
Задайте значение N. 
Напишите программу, которая выведет все натуральные числа от 1 до N
==================================================================*/

int ReadData()
{
    Console.Write("Задайте натуральное число: ");
    return Convert.ToInt32(Console.ReadLine());
}



int NuturalNumberPrinter(int number)
{    
    if (number == 2) return 1; // остановка метода. крайний случай в рекурсии. условие остановки рекурсии 
    else
    {
        // уменьшаем число на 1
        number--;
        // печатает ход рекурсии
        Console.WriteLine(number);
        // вызываем метод внутри метода (метод вызывает сам себя), но с уменьшенным на 1 числом
        Console.Write(NuturalNumberPrinter(number) + " ");
    }
    return number;
}

/* Стек
number = 4
1-ый шаг: num = 4 - не удовлетворяет условию остановки рекурсии. 
                    переходит в if. num уменьшается на 1. num = 3. Напечаталось 3. В скек не сохранлись 
                    num = 3 ушло на повторную рекурсию. 
                    Console.Write(NuturalNumberPrinter(number) - напечататься не могло, 
                    т.к. обратились к тому же методу, но уже с num = 3

2-ой шаг:  передали методу num = 3 - не удовлетворяет условию остановки рекурсии.
                                      переходит в if. num уменьшается на 1. num = 2. Напечаталось 2. Сохранилось в скек
                                      дальше опять метод обращается сам к себе и запускается заново. 
3- ий шаг: передали методу num = 2 - удовлетворяет условию остановки рекурсии
                                     рекурсия остановилась и метод вернул 1. Ничего не напечаталось.
Рукурсия остновилась и метод вернул num. Рекурсия начала обратный ход и выдало то, что было в стеке. (1, 2) 

РЕШЕНИЕ при num=4
PS D:\repo\C#\Block_4\Task_040-Sem9_1> dotnet run
Задайте натуральное число: 4
3
2
1 2
*/ 



int inputNumber = ReadData();
// +2 чтобы включить предпоследнее и последнее числа в ряду 
NuturalNumberPrinter(inputNumber+2);

