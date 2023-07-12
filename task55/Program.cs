// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.


int [,] RotateMatrix(int[,] matrix)
{
int [,] newMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
for (int i = 0; i < newMatrix.GetLength(0); i++)
{
for (int j = 0; j < newMatrix.GetLength(1); j++)
{
newMatrix[i,j] = matrix[j,i];
}
}

return newMatrix;
}


int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
int[,] tempMatrix = new int[row, col];
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
//Ввод данных
int[] ReadInt(string text)
{
System.Console.Write(text);
return Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse); ;
}
//Печать двумерного массива
void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
System.Console.Write(matrix[i, j] + "\t");
}
System.Console.WriteLine();
}
}



//..........................
int[] size = ReadInt("Задайте количество строк и столбцов через запятую: ");
int[] range = ReadInt("Задайте левую и правую границы массива через запятую: ");
int[,] matrix = FillMatrix(size[0], size[1], range[0], range[1]);

PrintMatrix(matrix);

System.Console.WriteLine("");

PrintMatrix(RotateMatrix(matrix));