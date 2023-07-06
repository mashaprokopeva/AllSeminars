// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


int[] FillArray(int size, int leftRange, int rightRange)
{
int[] tempArray = new int[size];
Random rand = new Random();

for (int i = 0; i < tempArray.Length; i++)
{
tempArray[i] = rand.Next(leftRange, rightRange + 1);
}
return tempArray;
}

void Convert(int[] tempArray)
{
for (int index = 0; index < tempArray.Length; index++)
{
tempArray[index] *= -1;
}
}

void PrintArray(int[] arrayForPrint)
{
System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}
//+|+|+|+|+|+|+|+|+|+|+|+|


int [] array = FillArray(11, -15, 15);
PrintArray(array);
Convert(array);
PrintArray(array);