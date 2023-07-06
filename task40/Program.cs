// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

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

bool CheckTriangle(int[] array)
{
if ((array[0] < array[1] + array[2]) && (array[1] < array[0] + array[2]) && (array[2] < array[1] + array[0]))
{
return true;
}
return false;
}
//.........................
int[] array = FillArray(3, 15, 20);

PrintArray(array);
//bool check = CheckTriangle(array);

if (CheckTriangle(array))
{
System.Console.WriteLine("Такой треугольник существует!");
}
else
{
System.Console.WriteLine("Такой треугольник не существует!");

}