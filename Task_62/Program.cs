// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] CreateMatrixRndInt(int m, int n)
{
    int[,] arr = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(1, 16);
        }
    }
    return arr;
}


void SortBySpiralMatrix(int[,] arr)
{
    int i;
    int startRowIndex = 0;
    int startColumnIndex = 0;
    int endRowIndex = arr.GetLength(0);
    int endColumnIndex = arr.GetLength(1);

    while (startRowIndex < endRowIndex && startColumnIndex < endColumnIndex)
    {
        for (i = startColumnIndex; i < endColumnIndex; i++)
        {
            Console.Write(arr[startRowIndex, i] + " ");
        }
        startRowIndex++;

        for (i = startRowIndex; i < endRowIndex; i++)
        {
            Console.Write(arr[i, endColumnIndex - 1] + " ");
        }

        endColumnIndex--;

        if (startRowIndex < endRowIndex)
        {
            for (i = endColumnIndex - 1; i >= startColumnIndex; i--)
            {
                Console.Write(arr[endRowIndex - 1, i] + " ");
            }
            endRowIndex--;
        }

        if (startColumnIndex < endColumnIndex)
        {
            for (i = endRowIndex - 1; i >= startRowIndex; i--)
            {
                Console.Write(arr[i, startColumnIndex] + " ");
            }
            startColumnIndex++;
        }

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

int[,] arrayCreate = CreateMatrixRndInt(4, 4);
PrintMatrix(arrayCreate);
Console.WriteLine();
SortBySpiralMatrix(arrayCreate);



