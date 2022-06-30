// Задача 21: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты  1 точки");
Console.WriteLine("x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты  2 точки");
Console.WriteLine("x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double num = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
double result = Math.Sqrt(num);
Console.WriteLine(result);
