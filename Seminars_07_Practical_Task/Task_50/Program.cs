/* Выполнил Кошелев Андрей/ Группа GU | Разработчик | 2789 |
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого элемента в массиве нет.
*/


Console.WriteLine("Создайте массив.");
Console.WriteLine("Введите количество строк и столбцов через пробел: ");
string[] input = Console.ReadLine().Split();
int rows = int.Parse(input[0]);
int columns = int.Parse(input[1]);
int[,] myArray = GetArray(rows, columns);
PrintArray(myArray);

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

Console.WriteLine("Введите значение позиции (строка столбец ) через пробел: ");
string[] position = Console.ReadLine().Split();
int horizontal = int.Parse(position[0]);
int vertical = int.Parse(position[1]);

if (horizontal > myArray.GetLength(0) || vertical > myArray.GetLength(1))
{
    Console.WriteLine("ERROR: Значение позиции за пределами массива.");
}
else
{
    Console.WriteLine($"Значение элемента {horizontal} строки и {vertical} столбца => {myArray[horizontal - 1, vertical - 1]}");
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
Console.WriteLine();