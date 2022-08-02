/* Выполнил Кошелев Андрей/ Группа GU | Разработчик | 2789 |
Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел
от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

Console.WriteLine("ВВедите число");
int a = int.Parse(Console.ReadLine());
int numbersSum = 0;

for(int i = 1; i <=a; i++)
{
    numbersSum = numbersSum + i;
}
Console.WriteLine(numbersSum);
