// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. \
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] CreateMatrixRndInt(int m, int n, int l)
{
    List<int> list = new List<int>();
    int[,,] arr = new int[m, n, l];
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                bool flag = false;
                while (flag == false)
                {
                    int number = random.Next(10, 99);
                    if (!list.Contains(number))
                    {
                        list.Add(number);
                        arr[i, j, k] = number;
                        flag = true;
                    }
                }
            }
        }
    }
    return arr;
}

void PrintMatrix(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k],3}" + " (" + i + "," + j + "," + k + ")");
            }
            Console.WriteLine();
        }
    }
}
int[,,] matrix1 = CreateMatrixRndInt(2, 2, 2);
PrintMatrix(matrix1);

