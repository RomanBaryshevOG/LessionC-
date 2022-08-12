// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.

Console.Write("Введите координату x для первой точки: ");
int x1 = int.Parse(Console.ReadLine());

Console.Write("Введите координату y для первой точки: ");
int y1 = int.Parse(Console.ReadLine());

Console.Write("Введите координату x для второй точки: ");
int x2 = int.Parse(Console.ReadLine());

Console.Write("Введите координату для второй точки: ");
int y2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y1 - y2) * (y1 - y2));
Console.WriteLine("Расстояние между точками равно {0: #.##}", result);
