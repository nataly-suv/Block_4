/* ==================================================
Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько  чисел больше 0 ввёл пользователь.
=====================================================*/

Console.WriteLine("Введите ряд чисел: ");
string? inputString = Console.ReadLine();

inputString = inputString.Replace(" ", ""); // удадида пробелы 

int countComma = 0;
int countMinus = 0;
int countNull = 0;

if (inputString.Length != 0)
{
    for (var i = 0; i < inputString.Length; i++)
    {
        if (inputString[i] == ',') countComma = countComma + 1;
        if (inputString[i] == '-') countMinus = countMinus + 1;
        if (inputString[i] == '0') countNull = countNull + 1;
    }
    int answer = countComma + 1 - countMinus - countNull;
    Console.WriteLine($"Количество положительных чисел: {answer}");
}
else Console.WriteLine("Вы ввели пустую строку");
 


