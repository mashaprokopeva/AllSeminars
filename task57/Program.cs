// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.
//Генерация массива
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
    return tempMatrix;
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
//Ввод данных
int[] ReadInt(string text)
{
    System.Console.Write(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse); ;
}
int[] DictionaryMatrix(int[,] matrix)
{
    int[] countArray = new int[10];
    for (int k = 0; k < 10; k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (k == matrix[i, j])
                {
                    countArray[k]++;
                }

            }

        }
    }
    return countArray;
}

void PrintDictionary(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != 0)
        {
            System.Console.WriteLine($"Число {i} встречается {array[i]} раз");
        }
    }
}
//..

int[] size = ReadInt("Задайте количество строк и столбцов через запятую: ");
int[,] matrix = FillMatrix(size[0], size[1], 0, 9);

PrintMatrix(matrix);
System.Console.WriteLine("");
PrintDictionary(DictionaryMatrix(matrix));
int[] DictionaryMatrix(int[,] matrix)
{
    int[] countArray = new int[10];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            countArray[matrix[i, j]]++;
        }
    }
    return countArray;
}