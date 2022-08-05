/*Выполнил Кошелев Андрей/ Группа GU | Разработчик | 2789 |
Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
Пример:
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Write("Введите основание степени число A => ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите показатель степени число B => ");
int n = int.Parse(Console.ReadLine());
int degree = 1;

for (int i = 0; i < n; i++)
{
    degree = degree * a;
}

if (n >= 1)
{
    Console.Write("Число A в степени B => " + degree); ;
}
else
{
    Console.Write("ERROR!!! Ошибка!!! Введите натуральную степень (1,2,3,4....) ");
}