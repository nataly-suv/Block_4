/* Программа, кототрая принимает число, и
   выдает сумму цифр в числе 
*/

// метод сложения цифр 
int Sum(int x)
{
    int sum = 0;
    while (x > 0)
    {
        sum = sum + x % 10;
        x = x / 10;
    }
    return sum;
}


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

DateTime time = DateTime.Now;
Console.WriteLine("Сумма цифр в числе равна: " + Sum(num));
Console.WriteLine(DateTime.Now - time);



