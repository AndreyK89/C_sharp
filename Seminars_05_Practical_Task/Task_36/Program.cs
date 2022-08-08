/* Выполнил Кошелев Андрей/ Группа GU | Разработчик | 2789
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/



int[] numbers = new int[7];
Console.WriteLine($"Массив случайных чисел: ");
Console.Write("[");
FillPrintArray(numbers);


int sum = 0;
for (int i = 1; i < numbers.Length; i++)
{
    sum = numbers[i] + sum;
    i++;
}

Console.WriteLine();
Console.WriteLine($"Cумма элементов, стоящих на нечетных позициях = {sum}");


void FillPrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
        Console.Write($"{array[i]}");
      if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
        else
        {
            Console.Write("]");
        }
    }
}
