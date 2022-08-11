// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наидольшую цифру числа.

int number = new Random().Next(10, 100);
// Console.Write($"Случайное число из диапазона 10 - 99 => {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit == secondDigit) Console.WriteLine($"Цифры равны = {number} ");
else if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} =  {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа {number} = {secondDigit}");

// тернарный оператор
// int result = firstDigit > secondDigit ?(тогда) firstDigit :(иначе) secondDigit;