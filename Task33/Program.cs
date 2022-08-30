// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int[,] CreateMatrixRndInt(int row, int col, int min, int max) // создаем метод для создания массива исхожного
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max +1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) // Содаем метод который печатает массив
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(j < matrix.GetLength(1) -1 ?
            $"{matrix[i, j], 4}" : $"{matrix[i, j], 4}");
        }
        Console.WriteLine("]");
    }
}

void Dictionary(int[,] matrix) // 
{
    int[] array = new int[matrix.Length]; // создаем одномерный массив
    int k = 0;                            // создали переменную 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }

    Array.Sort(array);    // сортировка одномерного массива

    int count = 1; 
    int value = array[0];  // 
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] != value)
        {
            Console.WriteLine($"Значение {value} встречается {count} раз");
            value = array[i];
            count = 1;
        }
        else
        {
            value = array[i];
            count++;
        }
    }
}

int[,] mtrx = CreateMatrixRndInt(4, 3, 1, 9);
PrintMatrix(mtrx);

Console.WriteLine();

Dictionary(mtrx);
