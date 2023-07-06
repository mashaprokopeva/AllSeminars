﻿// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// два варианта решения
void ChangeElemets(int[,] matrix)
{
for (int i = 1; i < matrix.GetLength(0); i += 2)
{
for (int j = 1; j < matrix.GetLength(1); j += 2)
{

matrix[i, j] = (int)Math.Pow(matrix[i, j], 2);
}
}
}


// oid ChangeElemets(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// if (i % 2 != 0 & j % 2 != 0)
// {
// matrix[i, j] = (int)Math.Pow(matrix[i, j], 2);
// }
// }
// }
// }