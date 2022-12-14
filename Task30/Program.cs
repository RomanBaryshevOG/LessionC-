// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

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

void MatrixSumIDx(int[,] matrix) // в качестве параметра передаем в метод массив
{
    for (int i = 0; i < matrix.GetLength(0); i++) // проходим по строкам
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // проходим по столбцам
        {
            matrix[i, j] = i + j; // формула из задачи
        }
    }
    
}

int[,] array2D = CreateMatrixRndInt(3, 4, -9, 9); // возвращает массив, создали переменную array2D
PrintMatrix(array2D);
Console.WriteLine(); // для пробела между массивами в резльтате
MatrixSumIDx(array2D);
PrintMatrix(array2D);