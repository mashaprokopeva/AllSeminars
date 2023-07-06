// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
int ReadInt(string text)
{
System.Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}
void Fibonacci(int number){
System.Console.Write("0 1 ");
int n1 = 0;
int n2 = 1;
int result = 0;
for (int i = 2; i < number ; i++)
{
result = n1 + n2;
System.Console.Write(result+" ");
n1 = n2;
n2 = result;
}
}

int number = ReadInt("Введите число: ");
Fibonacci(number);



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

int[] CopyArray(int[] inputArray)
{
int[] outputArray = new int[inputArray.Length];
for(int i = 0; i < inputArray.Length; i++)
{
outputArray[i] = inputArray[i];
}
return outputArray;
}

// —-------------------
int[] array = FillArray(5, 0, 10);
int[] arr2 = array;
// int[] arr2 = array[..];
// int[] arr2 = CopyArray(array);

array[0] = 100;
arr2[2] = 1000;

PrintArray(array);
PrintArray(arr2);



int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);