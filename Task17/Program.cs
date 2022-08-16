// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] NewArray()
{
int[] array = new int[8];
for (int i = 0; i <= 7; i++)
{
    array[i] = new Random().Next(0, 2);
}


    return array;
}

int[] array = NewArray();

for (int i = 0; i <= 7; i++)
{
    Console.Write($" {array [i]}, ");
}
