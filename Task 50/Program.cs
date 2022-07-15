// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

Console.Clear();

Console.WriteLine("Чтобы создать массив следуйте инструкциям!");

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение элементов массива: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элементов массива: ");
int max = int.Parse(Console.ReadLine());

Console.WriteLine("Чтобы узнать значение элемента в массиве введите координаты его позиции!");

Console.Write("Введите номер строки: ");
int line = int.Parse(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int column = int.Parse(Console.ReadLine());

int[,] CreateMatrixRndInt(int m, int n, int minimum, int maximum)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(minimum, maximum + 1);
        }
    }
    return arr;
}

void MatrixUserElement(int[,] inArray, int lineNumber, int columnNumber)
{
    int i = (lineNumber - 1);
    int j = (columnNumber - 1);
    if ( i < inArray.GetLength(0) && i >= 0 && j < inArray.GetLength(1) && j >= 0)
    {
        Console.WriteLine(inArray[(lineNumber - 1), (columnNumber - 1)]);
    }
    else Console.WriteLine($"{lineNumber}, {columnNumber} - числа с такими координатами в массиве нет!");
    return;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3} |");
            else Console.Write($"{arr[i, j],3} |");
        }
        Console.WriteLine();
    }
}

int[,] arrayResult = CreateMatrixRndInt(m, n, min, max);
PrintMatrix(arrayResult);
MatrixUserElement(arrayResult, line, column);

// Координаты задаются в пользовательском формате, то есть предполагается что пользователь не знает что массив начинается не с 1, а с 0 элемента.