﻿// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.


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

void ChangFirstAndLast(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLongLength(0) -1, i] = temp;
    }
}

int[,] mtrx = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(mtrx);

Console.WriteLine();

ChangFirstAndLast(mtrx);
PrintMatrix(mtrx);
