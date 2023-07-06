// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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
void PrintArray(int[] arrayForPrint)
{
System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}


int[] FirstAndLast(int[] tempArray)
{
int[] newArray = new int[tempArray.Length / 2 + tempArray.Length % 2];

for (int i = 0; i < tempArray.Length / 2; i++)
{
newArray[i] = tempArray[i] * tempArray[tempArray.Length - i - 1];
}
if (newArray.Length % 2 != 0)
{
newArray[newArray.Length - 1] = tempArray[tempArray.Length / 2];
}
return newArray;
}



int[] array = FillArray();
PrintArray(array);
PrintArray(FirstAndLast(array));


