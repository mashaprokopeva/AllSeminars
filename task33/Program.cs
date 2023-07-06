// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

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

int ReadInt(string text)
{
System.Console.WriteLine(text);
return Convert.ToInt32(Console.ReadLine());
}

bool FindNumber(int[] array, int number)
{
for (int i = 0; i < array.Length; i++)
{
if (array[i] == number)
{
return true;
}
}
return false;
}

int[] array = FillArray(12, 1, 10);
PrintArray(array);
int number = ReadInt("Введите искомое число: ");
bool find = FindNumber(array, number);
if (find)
{
System.Console.WriteLine("Да!");
}
else
{
System.Console.WriteLine("Нет!");
}