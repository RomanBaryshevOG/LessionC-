// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] CreateArrayRndInt(int size, int min, int max) // тип возвращаемого знаения, имя метода, RndInt случайных целых чисел, в скобках параметр размер масива, промежуток мин и макс.


{
     int[] array = new int [size]; // создаем массив
     Random rnd = new Random(); // создать объект который содержит метод для работы со случайными числами, файлик с методами

     for (int i = 0; i < size; i++)  // цикл для прохождения всех элементов массива
     {
        array[i] = rnd.Next(min, max + 1); // заполняем массив, последнее значение не входит в диапазон
     }
     return array; // возвращаем массив
}

void PrintArray(int[] array) // создадим метод для печати массива в консоль, в качестве параметра массив который создали
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++) // цикл для прохождения по всем числам массива
    {
    
        if (i < array.Length -1) Console.Write($"{array[i]}, "); // выводим в консоль, добваляем пробел для отступа между числами
        else Console.Write(array[i]); // чтобы у последнего числа небыло запятой
    }
    Console.Write("]");
    Console.WriteLine();
}

// void ReverseArray (int[] array)
// {
//     int size = array.Length;
//     int index1 = 0;
//     int index2 = size -1;


//     while (index1 < index2)
//     {
//         int obj = array[index1];
//         array[index1] = array[index2];
//         array[index2] = obj;

//         index1++;
//         index2--;
//     }
// }

void ReverseArray1 (int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size / 2; i++)
    {
        int temp = array[i];
        array[i] = array[size - 1 - i];
        array[size - 1 - i] = temp;
    }
}



int[] arr = CreateArrayRndInt(5, 1, 9);
PrintArray(arr);
//ReverseArray(arr);
PrintArray(arr);
ReverseArray1(arr);
PrintArray(arr);