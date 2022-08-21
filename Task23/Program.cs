
// Двумерные массивы и рекурсии.



// string[,] table = new string[2, 5]; // тип данных стринг 2 строчки и 5 солбцо



// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int colums = 0; colums < 5; colums++)
//     {
//         Console.WriteLine($"-{table[rows, colums]}-");
//     }
// }

void PrintArray(int[,] matr)
{


    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}


void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // GetLength(0) - указвает количество строк массива
    {
        for (int j = 0; j < matr.GetLength(1); j++) // GetLength(1) - указывает кол-во столбцов
        {
            matr[i, j] = new Random().Next(1,10); // [1; 10)
        }
        
    }
}



int[,] matr = new int[3, 4];
PrintArray(matr);

FillArray(matr);
Console.WriteLine();
PrintArray(matr);