// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти от 1 до 4: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string GetRange(int q)
{
    if (q == 1) return " x + и y + " ;
    if (q == 2) return " x - и y + " ;
    if (q == 3) return " x - и y - " ;
    if (q == 4) return " x + и y - " ;
    return "Введено некорректное значение";
}
string result = GetRange(quarter);
Console.WriteLine(result);

