// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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


int GetSumOddElem(int[] array2)
{
     int sum = 0;
    for (int i = 1; i < array2.Length; i=i+2)
    {
        sum += array2[i];
         
    }
    return sum;
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

void PrintSum(int sum)
{
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов стоящих на нечетных позициях массива = {sum}");
}

int[] array = CreateArrayRnd(5, 0, 10);
PrintArray(array);
int sumOddElem = GetSumOddElem(array);
PrintSum(sumOddElem);


