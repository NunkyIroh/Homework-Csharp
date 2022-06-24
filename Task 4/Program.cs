// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

using System.Linq;

Console.WriteLine("Чтобы увидеть максимальное число из трёх: ");

Console.WriteLine("Введите три целых числа через пробел ");

int[] nums = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
Console.WriteLine("Максимальное число из трёх: " + nums.Max().ToString());