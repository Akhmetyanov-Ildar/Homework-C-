// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int m, int n)
{
    int[,] arr = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(1, 20);
        }
    }
    return arr;
}

int FindMinSumElement(int[,] arr)
{
    int sum = int.MaxValue;
    int index = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            temp += arr[i, j];
        }
        if (temp < sum)
        {
            sum = temp;
            index = i + 1;
        }

    }
    return index;
}



void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3} | ");
            else Console.Write($"{arr[i, j],3} | ");
        }
        Console.WriteLine();
    }
}

int[,] arrayCreate = CreateMatrixRndInt(3, 5);
PrintMatrix(arrayCreate);
Console.WriteLine();
int sum = FindMinSumElement(arrayCreate);
Console.WriteLine($"номер строки с наименьшей суммой элементов: {sum} строка");
