// Напишите программу которая на вход принимает два числа,
// и проверяет является ли одно число квадратом другому.

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if ( num1 * num1 == num2 || num2 * num2 == num1 )
{
    Console.Write("Является квадратом");
}
else 
{
    Console.Write("Не является квадратом");
}