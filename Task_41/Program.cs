// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


Console.Write("Введите элементы(через запятую и пробел): ");

int[] GetArray()
{
    string userInput = Console.ReadLine();
    string[] strings = userInput.Split(", ");
    return Array.ConvertAll(strings, int.Parse);
}


int GetNumMoreZero(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void PrintPozitiveNumberCount(int[] arr2)
{
    Console.WriteLine($"Кол-во элементов > 0: {GetNumMoreZero(arr2)}");
}

int[] array = GetArray();
// int numMoreZero = GetNumMoreZero(array);
PrintPozitiveNumberCount(array);




