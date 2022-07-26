﻿/* Выполнил Кошелев Андрей/ Группа GU | Разработчик | 2789 |
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

Console.WriteLine("Введите значение позиции (строка столбец ) через пробел: ");
string[] position = Console.ReadLine().Split();
int horizontal = int.Parse(position[0]);
int vertical = int.Parse(position[1]);

if (horizontal > randomarrey.GetLength(0) || vertical > randomarrey.GetLength(1))
{
    Console.WriteLine("ERROR: Значение позиции за пределами массива.");
}
else
{
    Console.WriteLine($"Значение элемента {horizontal} строки и {vertical} столбца => {randomarrey[horizontal - 1, vertical - 1]}");
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


//  Решение от Ивана Русанова.

/* 
int InputExamNumber() // ввод и проверка числа
{
    while (true)
    {
        string text = Console.ReadLine();
        if (int.TryParse(text, out int number))
        {
            return number;
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]}");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
void FindNumber(int[,] matr, int value)
{
    int count = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == value)
            {
                Console.WriteLine($"{count + 1} позиция числа: строка {i+1} и столбец {j+1}");
                count++;
            }
        }
    }
    if (count == 0) Console.WriteLine("Такого элемента нет");
}

Console.WriteLine("Введите количество строк");
int m = InputExamNumber();
Console.WriteLine("Введите количество столбцов");
int n = InputExamNumber();
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine("Введите число");
int x = InputExamNumber();
FindNumber(array, x);
*/
