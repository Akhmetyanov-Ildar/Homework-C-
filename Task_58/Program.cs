// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultipleTwoMatrix(int[,] arr1, int[,] arr2)
{
    if (arr1.GetLength(0) != arr2.GetLength(1))
    {
        Console.WriteLine("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");

    }
    var arr3 = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {

            arr3[i, j] = 0;
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                arr3[i, j] += arr1[i, k] * arr2[k, j];
            }

        }

    }
    return arr3;
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

int[,] matrix1 = CreateMatrixRndInt(2, 2);
int[,] matrix2 = CreateMatrixRndInt(2, 2);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
int[,] matrix3 = MultipleTwoMatrix(matrix1, matrix2);
Console.WriteLine();
PrintMatrix(matrix3);