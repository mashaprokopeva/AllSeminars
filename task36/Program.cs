// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int a = 5;
int[] tempArray = new int[a];
void mas(int a)
{
    
    for (int i = 0; i < a; i++)
    {
        tempArray[i] = new Random().Next(1,9);
        Console.Write(tempArray[i] + ",");
    }
}

int Kol(int[] tempArray)
{
int sum = 0;
int i = 0;
while (i < tempArray.Length)
{
    sum = sum + tempArray[i];
    i = i + 2;
}
return sum;
}

mas(a);
Console.Write($"\nСумма элементов, стоящих на нечётных позициях: {Kol(tempArray)}");


