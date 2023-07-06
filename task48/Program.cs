// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// rows = 3, cols = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
int[,] FillMatrixFromPos(int row = 3, int col = 4, int minNum = -10, int maxNum = 10)
{
int[,] tempMatrix = new int[row, col];
for (int i = 0; i < tempMatrix.GetLength(0); i++)
for (int j = 0; j < tempMatrix.GetLength(1); j++)
tempMatrix[i, j] = i+j;
return tempMatrix;
}