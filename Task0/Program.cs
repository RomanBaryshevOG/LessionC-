// Напишите программу, которая на вход принимает число и выдает его квадрат.

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int square = num * num;
Console.Write($"Квадрат числа {num} = {square}"); // $ - интерполяция строк
