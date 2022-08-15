/* ==================================================================
Напишите программу, которая принимает на вход три числа 
и проверяет, может ли существовать треугольник с сторонами такой длины
===================================================================== */

int sideA = 0;
int sideB = 0;
int sideC = 0;

// метод считывания переменных 

void ReadSide()
{
    Console.Write("Введите длину стороны А: ");
    sideA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите длину стороны B: ");
    sideB = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите длину стороны C: ");
    sideC = Convert.ToInt32(Console.ReadLine());
}

// метод проверки теугольника 
bool TestTriangle(int num1, int num2, int num3)
{
    // используем тернальный оператор "тип имя_переменной = (условие) ? значение1 : значение2"
    bool answer = ((num1 + num2 > num3)
    && (num1 + num3 > num2)
    && (num2 + num3 > num1)) ? true : false;
    return answer;
}

// метод печати результата 
void PrintResult(bool answer)
{
    if (answer) Console.Write("Из этих отрезков можно составить теругольник");
    else Console.Write("Из этих отрезков нельзя составить теругольник");
}


ReadSide();
bool result = TestTriangle(sideA, sideB, sideC);
PrintResult(result);
