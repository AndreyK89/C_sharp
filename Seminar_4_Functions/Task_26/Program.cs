/* Выполнил Кошелев Андрей/ Группа GU | Разработчик | 2789 |
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.WriteLine(" Введите число: ");
/* string num = Console.ReadLine() 
int len = num.Lenght;
Console.WriteLine(len);
*/
int num = int.Parse(Console.ReadLine());
int i = 0;
while(num != 0 )
{
    num = num / 10;
    i++;
    
}
Console.Write(i);
