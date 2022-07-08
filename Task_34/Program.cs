// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// 1. Проверить что число положительное и трехзначное
// 2. Посчитать количество четных чисел в массиве.
// 3. Вывести на экран сам массив и колчество четных чисел.

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


int GetEvenElem(int[] array2)
{
    int count = 0;
    for (int i = 0; i < array2.Length; i++)
    {
        if (array2[i] %2 == 0)
        {
            count++;
        }
        
    }
    return count;
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

void PrintCountEvenElem(int count)
{
    Console.WriteLine();
    Console.WriteLine($"Количество четных чисел в массиве равняется = {count}");
}

int[] array = CreateArrayRnd(10, 100, 1000);
PrintArray(array);
int evenElemCount = GetEvenElem(array);
PrintCountEvenElem(evenElemCount);


