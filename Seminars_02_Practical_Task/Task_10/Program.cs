﻿/* 
Выполнил Кошелев Андрей/ Группа GU | Разработчик | 2789 |
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine());

if (n < 0)
{
    n = (n * -1);
}

if (n > 99 & n < 1000)
{
    int x = n / 10 % 10;
    Console.WriteLine("Вторая цифра введенного числа: " + x);
}
else
{
     Console.WriteLine(n + " не трехзначное число");
}