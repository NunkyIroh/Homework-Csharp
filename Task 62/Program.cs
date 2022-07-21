// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

Console.WriteLine("Чтобы создать массив следуйте инструкциям!");

Console.Write("Введите размер квадратного массива: ");
int n = int.Parse(Console.ReadLine());
int m = n;

// Console.Write("Введите количество строк массива: ");
// int m = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int n = int.Parse(Console.ReadLine());

// Console.Write("Введите минимальное значение элементов массива: ");
// int min = int.Parse(Console.ReadLine());

// Console.Write("Введите максимальное значение элементов массива: ");
// int max = int.Parse(Console.ReadLine());

// int[,] CreateMatrixRndInt(int m, int n, int minimum, int maximum)
// {
//     int[,] arr = new int[m, n];
//     Random rnd = new Random();

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = rnd.Next(minimum, maximum + 1);
//         }
//     }
//     return arr;
// }

// int[,] GetSpire(int m, int n)  // Этот метод скопировал и перенастроил по нашу задачу, поизучав решил написать сам.
// {
//     int[,] newMatrix = new int[m, n];
//     int row = 0;
//     int col = 0;
//     int dx = 1;
//     int dy = 0; 
//     int dirChanges = 0;
//     int gran = n;

// for (int i = 0; i < newMatrix.Length; i++)
// {
//     newMatrix[col, row] = i + 1;
//     if (--gran == 0)
//     {
//         gran = n * (dirChanges % 2) + m * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
//         int temp = dx;
//         dx = -dy;
//         dy = temp;
//         dirChanges++;
//     }
//     col += dx;
//     row += dy;
// }
// return newMatrix;
// }

int[,] GetSpireMatrix(int n) // но пока додумался только как сделать для квадратного массива или где строк больше чем столбцов
{
    int[,] in_array = new int[m, n];
    int number = 1;
    for (int count = 0; count < n; count++)
    {
        for (int j = 0 + count; j < n - count; j++)
        {
            in_array[0 + count, j] = number;
            number++;
        }
        number--;
        for (int i = 0 + count; i < m - count; i++)
        {
            in_array[i, n - 1 - count] = number;
            number++;
        }
        number--;
        for (int j = n - 1 - count; j >= 0 + count; j--)
        {
            in_array[m - 1 - count, j] = number;
            number++;
        }
        number--;
        for (int i = m - 1 - count; i >= 1 + count; i--)
        {
            in_array[i, 0 + count] = number;
            number++;
        }
    }
    number--;
    return in_array;
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

int[,] arrayResult = GetSpireMatrix(n);
PrintMatrix(arrayResult);

