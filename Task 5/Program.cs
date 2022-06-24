// Задача 5: Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Чтобы определить целые числа от -N до N: ");

Console.WriteLine("Введите целое положительное число N ");
int num1 = Convert.ToInt32(Console.ReadLine());

int num2 = 0 - num1;

String result = string.Empty;

for (int i = num2; i <= num1; i ++)
{
    result = result + " " + i;
}
Console.WriteLine("Целые числа от -N до N: " +result);