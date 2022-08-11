/* Выполнил Кошелев Андрей/ Группа GU | Разработчик | 2789
Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3



Console.Write("Введите кол-во чисел для ввода: ");
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
        else count += 0;
    }
    Console.Write($"Чисел больше 0 введено: {count}");
}

void FillArry(int[] array)
{
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите любое число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
 */

Console.Clear();

Console.WriteLine($"Задача 41. Cколько чисел больше 0 ввёл пользователь \n");
Console.Write($"Введи число М(количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[m];

void InputNumbers(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введи {i + 1} число: ");
        massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}


int Comparison(int[] massiveNumbers)
{
    int count = 0;
    for (int i = 0; i < massiveNumbers.Length; i++)
    {
        if (massiveNumbers[i] > 0) count += 1;
    }
    return count;
}

InputNumbers(m);

Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");