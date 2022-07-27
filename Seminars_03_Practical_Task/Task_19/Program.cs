/*
Выполнил Кошелев Андрей/ Группа GU | Разработчик | 2789 |
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
char[] arr = num.ToString().ToCharArray();
int lenght = arr.Length;

if (lenght != 5)
{
    Console.WriteLine("ERROR: Число " + num + " не пятизначное.");
}
else if (arr[0] == arr[4] && arr[1] == arr[3])
{
    Console.WriteLine("УРА!!! Число " + num + " -> палиндром");
}
else
{
    Console.WriteLine("НЕТ: Число " + num + " -> не палиндром");
}
