// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


//int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse); // ! перед Split убирает желтые ошибки


// k1 * x + b1 = k2 * x + b2;
// k1 * x - k2 * x = (b2 - b1)
// x(k1 - k2) = (b2 - b1)
// x = (b2 - b1)/(k1 - k2) // эти числа вводят пользователи 
void koordinate(int b1, int k1, int b2, int k2, out double x, out double y)
{
    x = (double)(b2 - b1) / (k1 - k2);
    y = (double)k1 * x + b1;
}
// Вывод числ
int[] ReadInt(string text)
{
    Console.WriteLine(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
}
int[] nums = ReadInt("Введите b1, k1, b2, k2 через пробел: ");
Console.WriteLine($"{nums[0]},{nums[1]},{nums[2]},{nums[3]}");
koordinate(nums[0], nums[1], nums[2], nums[3], out double x, out double y);
Console.WriteLine($"x = {x}, y = {y}");



















//--------------- идеальное решение 
// const int COEFFICIENT = 0;
// const int CONSTANT = 1;
// const int X_COORD = 0;
// const int Y_COORD = 1;
// const int LINE = 1;
// const int LINE = 2;
// double[] lineData1 = InputLineData(LINE1);
// double[] lineData2 = InputLineData(LINE2);
// if (ValidateLines(lineData1, lineData2))
// {
//     double[] coord = FindCoords(lineData1, lineData2);
//     Console.Write($"Точка пересечения уравнений y = {lineData1[COEFFICIENT]}*x+{lineData1[CONSTANT]} && y = {lineData2[COEFFICIENT]}*x+{lineData2[CONSTANT]} ");
//     Console.WriteLine($"имеет координаты ({coord[X_COORD]}, {coord[Y_COORD]})");
// }
// // вывод числа 
// double Prompt(string message)
// {
//     System.Console.Write(message); // вывести сообщение
//     string value = Console.ReadLine(); // считывает с консоли строку 
//     double result = Convert.ToDouble(value); //преобразовывает строку в целое число
//     return result;
// }
// // Вывод данных по прямой 
// double[] InputLineData(int numberOfLine)
// {
//     double[] lineData = new double[2];
//     lineData[COEFFICIENT] = Prompt($"Введите коэффициент для {numberOfLine} прямой >");
//     lineData[CONSTANT] = Prompt($"Введите коэффициент для {numberOfLine} прямой >");
//     return lineData;
// }
// // Поиск координат 
// double[] FindCoords(double[] lineData1, double[] lineData2)
// {
//     {
//         double[] coord = new double[2];
//         coord[X_COORD] = (lineData1[CONSTANT] - lineData2[CONSTANT]) / (lineData2[COEFFICIENT] - lineData1[COEFFICIENT]);
//         coord[Y_COORD] = (lineData1[CONSTANT] * coord[X_COORD] + lineData1[COEFFICIENT]);
//         return coord;
//     }
//     bool ValidateLines(double[] lineData1, double[] lineData2)
//     {
//         if (lineData1[COEFFICIENT] == lineData2[COEFFICIENT])
//         {
//             Console.WriteLine("Прямые совпадают");
//             return false;
//         }
//         else
//         {
//             Console.WriteLine("Прямые параллельны");
//             return false;
//         }
//     }
//     return true;
// }