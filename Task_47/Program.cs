// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// Random rnd = new Random();
// double [,] A = new double [m,n];

Console.Clear();
double[,] CreateMatrixRndInt(int m, int n)
{
    double[,] arr = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.NextDouble() * 100;
        }
    }
    return arr;
}

void PrintMatrix(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($" {Math.Round((arr[i, j]), 2),3} | ");
            else Console.Write($"{Math.Round((arr[i, j]), 2),3} | ");
        }
        Console.WriteLine();
    }
}

double[,] matrix = CreateMatrixRndInt(5, 5);
PrintMatrix(matrix);