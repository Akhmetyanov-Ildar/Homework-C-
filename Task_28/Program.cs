// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

int multipl = 1;

for (int i = 1; i <= num; i++)
{
    multipl = multipl * i;

}
Console.WriteLine($"Произведение чисел от 1 до {num} = {multipl}");