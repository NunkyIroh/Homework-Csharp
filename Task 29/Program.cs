// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, 
// заполненный псевдослучайными числами и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

// Было немного не интересно делать только на 8 элементов, поэтому сделал на любое количество элементов.
// Чтобы было чисто 8 элементов можно num заменить цифрой 8.
// Надеюсь это не будет ошибкой.

Console.WriteLine("Введите длинну массива: ");
int num = int.Parse(Console.ReadLine());

int[] FillArray(int num)
{
    int[] array = new int[num];
    Random rand = new Random();
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = rand.Next(0, 99);
        index++;
    }
    return array;
}

void PrintArray(int[] col)
{
    Console.Write("[");
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }
    Console.Write("]");
}

int[] arr = FillArray(num);
PrintArray(arr);

// end