// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

int[] CreateArrayRnd(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();


    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}


int GetMaxMinElem(int[] array2)
{
     int max = array2[0];
     int min = array2[0];
    for (int i = 0; i < array2.Length; i++)
    {
        if (max < array2[i]) 
        {
            max = array2[i];
        }
          if (min > array2[i]) 
          {
            min = array2[i];
        } 
    }
    return max - min;
}

void PrintArray(int[] array3)
{
    for (int i = 0; i < array3.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array3.Length - 1) Console.Write(array3[i] + ",");
        else Console.Write(array3[i] + "]");
    }
}

void PrintDifMaxMin(int dif)
{
    Console.WriteLine();
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {dif}");
}

int[] array = CreateArrayRnd(5, 0, 10);
PrintArray(array);
int difMaxMin = GetMaxMinElem(array);
PrintDifMaxMin(difMaxMin);
