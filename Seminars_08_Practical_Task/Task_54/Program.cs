/* Выполнил Кошелев Андрей/ Группа GU | Разработчик | 2789 |
Задача 54: Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/


Console.WriteLine();
Console.WriteLine("Задан двухмерный массив:");

int[,] array = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};

PrintArray(array);

for (int i = 0; i < array.GetLength(0); i++)
{
    int[] newArray = new int[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        newArray[j] = array[i, j];
    }
    newArray = SortingArray(newArray);
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = newArray[j];
    }
}

Console.WriteLine("Массив упорядочен по убыанию элеменов в строках: ");
PrintArray(array);

int[] SortingArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] < array[j + 1])
            {
                int temp = array[j + 1];
                array[j + 1] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
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

Console.WriteLine();