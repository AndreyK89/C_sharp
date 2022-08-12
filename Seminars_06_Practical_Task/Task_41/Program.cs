/* Выполнил Кошелев Андрей/ Группа GU | Разработчик | 2789
Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

Console.Clear();

Console.WriteLine("Задача 41: Сколько чисел введено больше 0? ");
Console.Write("Введите количество чисел M для ввода: ");
int length = int.Parse(Console.ReadLine());
int[] array = new int[length];


FillArry(array);
WriteArray(array);
Positive(array);


void Positive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    Console.Write($"Чисел больше 0 введено: {count}");
}

void FillArry(int[] array)
{
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        array[i] = int.Parse(Console.ReadLine());
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "");

          if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
        else
        {
            Console.Write(".");
        }
    }
    Console.WriteLine();
}
Console.WriteLine();
