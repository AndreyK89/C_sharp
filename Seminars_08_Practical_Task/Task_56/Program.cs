/* Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.WriteLine();
Console.WriteLine("Задан двухмерный массив:");

int[,] array = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
    {5, 2, 6, 7},
};

PrintArray(array);


int tempSumm = 0;
for (var i = 0; i < array.GetLength(1); i++)
{
    tempSumm += array[0, i];
}

int position = 0;
for (var i = 0; i < array.GetLength(0); i++)
{
    int lineSumm = 0;
    for (var j = 0; j < array.GetLength(1); j++)
    {
        lineSumm += array[i, j];
    }
    Console.WriteLine($"Строка {i} = {lineSumm}");
    if (tempSumm > lineSumm)
    {
        tempSumm = lineSumm;
        position = i;
    }
}
Console.WriteLine($"Строка {position} с наименьшей суммой элементов = {tempSumm} ");

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
