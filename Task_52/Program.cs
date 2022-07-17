// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
int[,] CreateMatrixRndInt(int m, int n)
{
    int[,] arr = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(1, 10);
        }
    }
    return arr;
}

double[] GetAverageSum(int[,] arr)
{
    double[] average = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {

        for (int j = 0; j < arr.GetLength(0); j++)
        {
            average[i] += arr[j, i];
        }
        average[i] = average[i] / arr.GetLength(0);
    }
    return average;
}

void PrintEverage(double[] arr)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(Math.Round(arr[i], 1) + "; ");
    }
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

int[,] matrix = CreateMatrixRndInt(4, 3);
PrintMatrix(matrix);

PrintEverage(GetAverageSum(matrix));


