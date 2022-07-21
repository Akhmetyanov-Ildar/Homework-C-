// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] array = {{1,2,3,4,},
{5,6,7,8,},
{9,10,11,12,},
{13,14,15,16,}};

int[,] CreateMatrixRndInt(int[,] arr)
{
    int w = 4;
    int h = 4;
    int counter = 1;
    int startCol = 0;
    int endCol = w - 1;
    int startRow = 0;
    int endRow = h - 1;

    while (startCol <= endCol && startRow <= endRow)
    {
        for (int i = startCol; i <= endCol; i++)
        {
            arr[startRow, i] = counter;
            counter++;
        }
        startRow++;
        for (int j = startRow; j <= endRow; j++)
        {
            arr[j, endCol] = counter;
            counter++;
        }
        endCol--;
        for (int i = endCol; i >= startCol; i--)
        {
            arr[endRow, i] = counter;
            counter++;
        }
        endRow--;
        for (int i = endRow; i >= startRow; i--)
        {
            arr[i, startCol] = counter;
            counter++;
        }
        startCol++;
    }
    return arr;
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

PrintMatrix(array);
Console.WriteLine();
CreateMatrixRndInt(array);
PrintMatrix(array);


