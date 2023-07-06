// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = PowerLoop(A, B);
Console.WriteLine($"{A} в степени {B} равно {result}");
int PowerLoop(int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result *= A;
    }
    return result;
}
//-----------------------------------------
// int ReadInt(string text)
// {
//     Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int number1 = ReadInt("Введите первое число: ");
// int number2 = ReadInt("Введите второе число: ");
// Console.WriteLine($"{A} в степени {B} равно {result}");

int Power(int A, int B)
{
    int result = Multiply(A, A);
    for (int i = 2; i <= B; i++)
    {
        result = Multiply(result, A);
    }
    return result;
}


int Multiply(int x, int y)
{
    int result = 0;
    for (int i = 0; i < y; i++)
    {
        result = Add(result, x);
    }
    return result;
}


int Add(int x, int y)
{
    return x + y;
}
