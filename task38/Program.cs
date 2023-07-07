// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


//Console.Write("Введите количество элементов массива: ");
int a = 5;
double[] randomArray = new double[a];

void mas(int a)
{
Random rand = new Random();

for (int i = 0; i < a; i++)
{

//randomArray[i] = rand.NextDouble();
randomArray[0] = 3.22;
randomArray[1] = 5;
randomArray[2] = 3.22;
randomArray[3] = 1.2;
randomArray[4] = 3.23;
Console.Write($"{randomArray[i]:F2}" + ".");
}

}

double raz(double[] randomArray)
{
double min = randomArray[0];
double max = randomArray[0];
int i = 1;
while (i < randomArray.Length)
{
if (max<randomArray[i])
max = randomArray[i];
if (min>randomArray[i])
min = randomArray[i];
i = i + 1;
}
return max-min;
}

mas(a);
Console.Write($"\nРазница между максимальным и минимальным элементов массива: {raz(randomArray):F2}");