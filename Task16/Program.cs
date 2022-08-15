// Напишите задачу которая принимает на вход число N и 
// выдает произведение чисел от 1 до N.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 1;
for (int i = 1; i <= num; i++)
{
    num1 = num1 * i;
}
Console.WriteLine(num1);