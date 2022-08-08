/* Выполнил Кошелев Андрей/ Группа GU | Разработчик | 2789
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.WriteLine($"Массив случайных трёхзначных чисел: ");
int[] numbers = new int[7];
FillPrintArray(numbers);
Console.WriteLine();
SumPositive(numbers);


void SumPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    Console.WriteLine($"Количество чётных чисел в массиве -> {count} ");
}

void FillPrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]} ");
    }
    
}