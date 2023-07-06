// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// из семенара 
// void FillArray(int[] array)
// {
// Random rand = new Random();
// for (int index = 0; index < array.Length; index++)
// {
// array[index] = rand.Next(0, 2); // new Random().Next(0, 2)
// }
// }

// void PrintArray(int[] array)
// {
// System.Console.WriteLine("[" + string.Join(", ", array) + "]");
// }



//  не компелируется
// Вывод числа на экран
// int Prompt(string message)
// {
//     System.Console.WriteLine(message); //Выводим приглашение ко вводу
//     string ReadInput = System.Console.ReadLine();
//     int result = int.Parse(ReadInput); //приводим к числу
//     return result;
// }
// // Метод для получения случайных значений массива 
// int[] GenerateArray(int Length, int minValue, int maxValue)
// {
//     int[] array = new int[Length]; // Объявляем массив
//     Random random = new Random();
//     for (int i = 0; i < Length; i++)
//     {
//         array[i] = random.Next(minValue, maxValue + 1); // заполняем случайными цифрами из диапазлна SatrArr до EndArr
//     }
//     return array;
// }
// void PrintArray(int[] array)
// {
//     Console.Write("[");
// }
// for (int i = 0; i < array.Length - 1; i++)
// {
//     Console.Write($"{array[i]}, "); //вывод значения массива
// }
// Console.Write($"{array[array.Length - 1]}"); // вывод значения массива
// Console.WriteLine("]");

// int Length = Prompt("Длина массива: ");
// int min = Prompt("Начальное значение, для диапазона случайного числа: ");
// int max = Prompt("Конечное значение, для диапазона случайного числа: ");
// int[] array = GenerateArray(Length, min, max); //заполнение массива случайными числами
// PrintArray(array);// вывод массива



 
//Вывод числа на экран
int Prompt(string message)
{
    Console.WriteLine(message); // Выводим приглашение к вводу
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput); // Приводим к числу
    return result;
}

// Метод для получения случайных значений массива 
int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length]; // Объявляем массив
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1); // Заполняем случайными цифрами из диапазона minValue до maxValue
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, "); // Вывод значения массива
    }
    Console.Write($"{array[array.Length - 1]}"); // Вывод значения последнего элемента массива
    Console.WriteLine("]");
}
int Length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение для диапазона случайного числа: ");
int max = Prompt("Конечное значение для диапазона случайного числа: ");
int[] array = GenerateArray(Length, min, max); // заполнение массива случайными числами
PrintArray(array); // вывод массива