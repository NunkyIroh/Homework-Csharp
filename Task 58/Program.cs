// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

Console.WriteLine("Чтобы создать две матрицы следуйте инструкциям!");

Console.Write("Введите количество строк первой матрицы: ");
int line1 = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов первой матрицы: ");
int column1 = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение элементов первой матрицы: ");
int min1 = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элементов первой матрицы: ");
int max1 = int.Parse(Console.ReadLine());

Console.Write("Введите количество строк второй матрицы: ");
int line2 = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов второй матрицы: ");
int column2 = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение элементов второй матрицы: ");
int min2 = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элементов второй матрицы: ");
int max2 = int.Parse(Console.ReadLine());

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

int[,] MatrixSum(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0)) Console.WriteLine("Ошибка: количество столбцов 1-й матрицы должно быть равно количеству строк 2-й матрицы!");
    else
    {
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < secondMatrix.GetLength(1); j++)
            {
                for (int k = 0; k < secondMatrix.GetLength(0); k++)
                {
                    resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                }
            }
        }
    }
    return resultMatrix;
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

int[,] matrixOne = CreateMatrixRndInt(line1, column1, min1, max1);
Console.WriteLine("Первая матрица:");
PrintMatrix(matrixOne);
Console.WriteLine();

int[,] matrixTwo = CreateMatrixRndInt(line2, column2, min2, max2);
Console.WriteLine("Первая матрица:");
PrintMatrix(matrixTwo);
Console.WriteLine();

int[,] resultMatrix = MatrixSum(matrixOne, matrixTwo);
Console.WriteLine("Сумма матриц:");
PrintMatrix(resultMatrix);
