/* ===========================================================
Найдите площадь треугольника образованного пересечением 3 прямых.
Уравннеие, задающее прямую y=K*x+b
============================================================= */

int k1 = 0, b1 = 0;
int k2 = 0, b2 = 0;
int k3 = 0, b3 = 0;

// метод считывания данных 
void ReadDate()
{
    Console.Write("Введите k1=");
    k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите b1=");
    b1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите k2=");
    k2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите b2=");
    b2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите k3=");
    k3 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите b3=");
    b3 = Convert.ToInt32(Console.ReadLine());
}

// метод поиска пересечения 2 прямых (координаты точки)
double[] Crossing(int a1, int c1, int a2, int c2) // a=k, c=b
{
    double[] outArray = new double[2];
    outArray[0] = (c2 - c1) / (a1 - a2);
    outArray[1] = a1 * outArray[0] + c1;
    return outArray;
}

// метод поиска длины отрезка (стороны треугольника)
double LengthSide(double[] array1, double[] array2)
{
    double side = Math.Sqrt(Math.Pow((array1[0] - array2[0]), 2) + Math.Pow((array1[1] - array2[1]), 2));
    return side;
}


// метод поиска площади треугольника
double SquareTriangle(double side1, double side2, double side3)
{
    double p = (side1 + side2 + side3)/2; //полупериметр
    double square = Math.Round(Math.Sqrt(p*(p - side1) * (p - side2) * (p - side3)),3); // площадь
    return square;
}

// Метод печати массива 
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

ReadDate(); // вызываем метод для считывания переменных 

double[] crossing_1 = Crossing(k1, b1, k2, b2);  // первая точка пересечения 
PrintArray(crossing_1);
double[] crossing_2 = Crossing(k1, b1, k3, b3);  // вторая точка пересечения 
PrintArray(crossing_2);
double[] crossing_3 = Crossing(k2, b2, k3, b3);  // третья точка пересечения 
PrintArray(crossing_3);


double side1 = LengthSide(crossing_1, crossing_2);  // первая сторона 
double side2 = LengthSide(crossing_1, crossing_3);  // вторая сторона
double side3 = LengthSide(crossing_2, crossing_3);  // третья сторона

Console.Write("Площадь треугольника равна: ");
Console.WriteLine(SquareTriangle(side1, side2, side3));







