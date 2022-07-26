﻿/*  Выполнил Кошелев Андрей/ Группа GU | Разработчик | 2789 |
Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int m = Input("Введите значение M: ");
int n = Input("Введите значение N: ");

int Input(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

int result = NumberSum(n, m);
Console.WriteLine("Сумма натуральных элементов: ");
Console.WriteLine(result + " ");

int NumberSum(int n, int m)
{
    if (n <= m)
    {
        return n;
    }
    return n + NumberSum(n - 1, m);
} 
