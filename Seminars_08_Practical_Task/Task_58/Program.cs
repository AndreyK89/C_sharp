/* Выполнил Кошелев Андрей/ Группа GU | Разработчик | 2789 |
Задача 58: Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10   Неправильный    |   Правильный     70 61 46 69
20 81 8 6  <=   пример       |     пример  =>   61 119 92 76
56 8 4 24                    |                  46 92 100 88
10 6 24 49                   |                  69 76 88 114
*/



int[,] oneArray = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
    {5, 2, 6, 7},

};

Console.WriteLine("Первая матрица:");
PrintArray(oneArray);

int[,] twoArray = {
    {1, 5, 8, 5},
    {4, 9, 4, 2},
    {7, 2, 2, 6},
    {2, 3, 4, 7},
};

Console.WriteLine("Вторая матрица:");
PrintArray(twoArray);


int[,] matrixСomposition = newArrey(oneArray, twoArray);
PrintArray(matrixСomposition);

int[,] newArrey(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixСomposition = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrixСomposition[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    Console.WriteLine("Произведение матриц:");
    return matrixСomposition;
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
