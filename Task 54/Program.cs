// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

Console.Clear();

Console.WriteLine("Чтобы создать двумерный массив следуйте инструкциям!");

Console.Write("Введите количество строк массива: ");
int line = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int column = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение элементов массива: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элементов массива: ");
int max = int.Parse(Console.ReadLine());

int[,] CreateMatrixRndInt(int line, int column, int minimum, int maximum)
{
    int[,] matrix = new int[line, column];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minimum, maximum + 1);
        }
    }
    return matrix;
}

int[] MatrixinSortArray(int[,] in_matrix)
{
    int[] arrayForMethod = new int[in_matrix.Length];
    int count = 0;
    for (int i = 0; i < in_matrix.GetLength(0); i++)
    {
        for (int j = 0; j < in_matrix.GetLength(1); j++)
        {
            arrayForMethod[count] = in_matrix[i, j];
            count++;
        }
    }
    Array.Sort(arrayForMethod);
    return arrayForMethod;
}

int[,] SortArrayinMatrix(int[] sortArray)
{
    int[,] sortMatrix = new int[line, column];
    int count = 0;
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            sortMatrix[i, j] = sortArray[count];
            count++;
        }
    }
    return sortMatrix;
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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("Одномерный массив: ");
        if (i < array.Length - 1) Console.Write(array[i] + ",  ");
        else Console.Write(array[i] + ".");
    }
    Console.WriteLine("\b");
}

int[,] arrayResult = CreateMatrixRndInt(line, column, min, max);
Console.WriteLine("Ваш двумерный массив:");
PrintMatrix(arrayResult);
Console.WriteLine();

int[] sortArray = MatrixinSortArray(arrayResult);
Console.WriteLine("Ваш двумерный массив переведен в одномерный и отсортирован:");
PrintArray(sortArray);

int[,] sortMatrix = SortArrayinMatrix(sortArray);
Console.WriteLine("Ваш отсортированный двумерный массив:");
PrintMatrix(sortMatrix);
