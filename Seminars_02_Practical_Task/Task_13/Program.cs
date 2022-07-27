/* 
Выполнил Кошелев Андрей/ Группа GU | Разработчик | 2789 |
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

if (n < 0)
{
    n = (n * -1);
}
if (n < 100)
{
    Console.Write("В введенном числе нет третьей цифры");
}
else
{
    while (n > 999)
    {
        n = (n / 10);
    }
    Console.Write("Третья цифра введенного числа: " + n % 10);
}
