// Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int quadro = num2 * num2;
if (quadro == num1)
{
    Console.Write($"Первое число {num1} является квадратом числа {num2}");
}
else
{
    Console.Write($"Число {num1} не является квадратом {num2}");
}