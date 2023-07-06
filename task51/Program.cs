﻿// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//Сумма элементов главной диагонали: 1+9+2 = 12

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    // Random rand = new Random();
    var rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return tempMatrix;
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] matrixFotPrint)
{
    for (int i = 0; i < matrixFotPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixFotPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixFotPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
int DiagSquare(int[,] tempMatrix, int row, int col)
{
    int sum = 0;
    int iterations = Math.Min(row, col);
    for (int i = 0; i < iterations; i++)
    {
        sum += tempMatrix[i, i];
    }
    return sum;
}

// int DiagSquare(int[,] tempMatrix)
// {
// int sum = 0;
// for (int i = 0; i < tempMatrix.GetLength(0); i++)
// for (int j = 0; j < tempMatrix.GetLength(1); j++)
// if (i == j)
// sum+=tempMatrix[i,j];
// return sum;
// }

// ------------------------------

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");
int[,] matrix = FillMatrix(rows, cols, 0, 10);
PrintMatrix(matrix);
System.Console.WriteLine(DiagSquare(matrix, rows, cols));