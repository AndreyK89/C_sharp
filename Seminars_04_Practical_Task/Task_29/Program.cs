/* Выполнил Кошелев Андрей/ Группа GU | Разработчик | 2789 | 
Задача 29: Напишите программу, которая задаёт массив из 8 элементов
и выводит их на экран.
Пример:
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] Array = new int[8];
Console.WriteLine("Массив из 8 случайных элементов:");
Console.Write("[");
for (int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(0, 20);
    Console.Write(Array[i]);
    if (i < Array.Length - 1)
    {
        Console.Write(", ");
    }
    else
    {
        Console.Write("]");
    }
}
