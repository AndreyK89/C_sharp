﻿/* 
Выполнил Кошелев Андрей/ Группа GU | Разработчик | 2789 |
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите цифру: ");
int n = int.Parse(Console.ReadLine());

if (n == 6 | n == 7)
{
    Console.WriteLine("Этот день является выходным");
}
else if (n > 0 && n < 6)
{
    Console.WriteLine("Этот день не является выходным");
}
else
{
    Console.WriteLine("Такого дня недели нет");
}