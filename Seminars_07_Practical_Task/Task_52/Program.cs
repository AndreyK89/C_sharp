/* Выполнил Кошелев Андрей/ Группа GU | Разработчик | 2789 |
Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


Console.WriteLine("Создайте массив.");
Console.WriteLine("Введите количество строк и столбцов через пробел: ");
string[] input = Console.ReadLine().Split();
int rows = int.Parse(input[0]);
int columns = int.Parse(input[1]);
int[,] randomarrey = GetArray(rows, columns);
PrintArray(randomarrey);

int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

Console.WriteLine("Среднее арифметическое каждого столбца:");
Console.Write(" | ");
for (int j = 0; j < randomarrey.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < randomarrey.GetLength(0); i++)
    {
        avarage = (avarage + randomarrey[i, j]);
    }
    avarage = avarage / rows;
    avarage = Math.Round(avarage, 1);
    Console.Write(avarage + " | ");
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();

    }
}
