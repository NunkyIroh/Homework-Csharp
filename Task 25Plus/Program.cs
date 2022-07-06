// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в целую степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

Console.WriteLine("Чтобы возвести число А в целую степень В:");
Console.Write("1. Введите число А: ");
double A = Convert.ToInt32(Console.ReadLine());
Console.Write("2. Введите целую степень В: ");
double B = Convert.ToInt32(Console.ReadLine());

double IntDegree(double number, double degree)
{
    double result = 1;
    if (degree > 0)
    {
        for (int i = 1; i <= degree; i++)
        {
            result = result * number;
        }
    }
    else if (degree == 0)
    {
        result = 1;
    }
    else
    {
        for (int i = 1; i <= (-1 * degree); i++)
        {
            result = result * number;
        }
        result = 1 / result;
    }
    return result;
}

void PrintDegree(double Exp)
{
    Console.Write($"Результат возведения числа А {A} в степень {B} равен {Exp}!");
}

double res = IntDegree(A, B);
PrintDegree(res);

// end