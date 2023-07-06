// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Работают 2 варианта 
int CalculateDigitSum(int number)
{
    int sum = 0;
    while (number != 0)
    {
        int digit = GetLastDigit(number); //GetLastDigit - получаем последнюю цифру
        sum += digit;
        number = RemoveLastDigit(number); // RemoveLastDigit - удаляем последнюю цифру
    }
    return sum;
}

int GetLastDigit(int number)
{
    return number % 10;
}

int RemoveLastDigit(int number)
{
    return number / 10;
}
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int sum = CalculateDigitSum(number);
    Console.WriteLine($"Сумма цифр числа {number} равна {sum}");




// Console.WriteLine("Введите число: ");
// string input = Console.ReadLine();
// int number = Convert.ToInt32(input);
// int sum = CalculateDigitSum(number);
// Console.WriteLine($"Сумма цифр числа {number} равна {sum}");
 
//  int CalculateDigitSum(int number)
// {
//     int sum = 0;
//     string numberString = number.ToString(); // преобразуем число в строку (string numberString) и затем проходимся по каждому символу строки с помощью цикла for.
//     for (int i = 0; i < numberString.Length; i++)
//     {
//         char digitChar = numberString[i]; // (char digitChar = numberString[i]) для получения каждой цифры из строки numberString
//         int digit = Convert.ToInt32(digitChar.ToString());//  преобразуем каждый символ обратно в цифру (Convert.ToInt32(digitChar.ToString())) и добавляем его к сумме.  
//         sum += digit;
//     }
//     return sum;//возвращаем полученную сумму

// }
