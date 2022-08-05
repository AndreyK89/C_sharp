/* Выполнил Кошелев Андрей/ Группа GU | Разработчик | 2789 | 
   Задача 27: Напишите программу, которая принимает на вход число
    и выдаёт сумму цифр в числе.
    Пример:
    452 -> 11
    82 -> 10
    9012 -> 12
*/


Console.Write("Введите положительное целое число => ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Сумма цифр данного числа => " + Item(number));

int Item(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;

}