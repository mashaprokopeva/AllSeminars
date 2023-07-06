// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("ВВедите пятизначное число: ");
string input = Console.ReadLine(); 
if (input.Length != 5)
{
    System.Console.WriteLine("Вы ввели неправильное число!");
}
else if (input[0] == input[4] && input[1] == input[3])
{
    System.Console.WriteLine("Ваше число является палиндромом");
}
else
{
    System.Console.WriteLine("Ваше число не является палиндромом");
}








