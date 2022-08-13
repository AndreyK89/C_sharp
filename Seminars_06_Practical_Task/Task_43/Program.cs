/*Выполнил Кошелев Андрей/ Группа GU | Разработчик | 2789.
 Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
 значения b1, k1, b2 и k2 задаются пользователем.
 b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5;-0,5)
*/

Console.WriteLine();
Console.WriteLine("Задача 43:");
Console.WriteLine("Напишите программу, которая найдёт точку пересечения двух прямых,");
Console.WriteLine("заданных уравнениями:");
Console.WriteLine("y = k1 * x + b1; y = k2 * x + b2.");
Console.WriteLine("Введите значения:");

double b1 = SetValues("b1");
double k1 = SetValues("k1");
double b2 = SetValues("b2");
double k2 = SetValues("k2");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;

Console.Write($"Точка пересечения двух прямых: x({x}); y({y}). ");

double SetValues(string value)
{
    Console.Write($"{value}: ");
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

