// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 44 -> 101100
// 3 -> 11
// 2 -> 10

void ConverDecToBin(int number)
{
string bin = "";
while(number > 0)
{
bin += Convert.ToString(number%2);
number = number/2;
}
char [] array = bin.ToCharArray();
Array.Reverse(array);
System.Console.WriteLine(string.Join("",array));
}



int ReadInt(string text)
{
System.Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}

void GetBinaryView(int num)
{
if (num <= 0)
{
return;
}
GetBinaryView(num/2);
System.Console.Write(num%2);
}

// —-----------------------

int number = ReadInt("Введите число: ");
GetBinaryView(number);
int ReadInt(string text)
{
System.Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}

// —-----------------------

int number = ReadInt("Введите число: ");
System.Console.WriteLine(Convert.ToString(number, 2));