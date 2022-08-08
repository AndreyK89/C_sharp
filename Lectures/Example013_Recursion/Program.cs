// |  |  |  |  |  | ## Двумерные массивы

//string[,] table = new string [2, 3]; /// тип данных[,] наименование =  new string [2, 3];

//int[,] matrix = new int[5,8] // [5, 8] - 5 строки, 8 столбцы


//string[,] table = new string[2, 5];

// String.Empty //по умолчанию инициализация для строк такой Константой
// table [0, 0]  table [0, 1]  table [0, 2]  table [0, 3]  table [0, 4]
// table [1, 0]  table [1, 1]  table [1, 2]  table [1, 3]  table [1, 4]

//  table [1, 2] = "слово"; // в таблице указали индекс строки и индекс столбца
////////////////////////////////////////////////////////////////////////////////////////
// // Выводим на печать
// for(int rows = 0; rows< 2; rows++) // rows - строки
// {
//     for (int columns = 0; columns < 5; columns++) // columns - колоны(столбцы)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

// int[,] matrix = new int[3, 4];

// for (int i = 0; i < 3; i++) // проходимся по строкам
// {
//     for (int j = 0; j < 4; j++) // проходимся по столбцам
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }

// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);
/*
void PrintArray(int[,] matr)  // Метод(функция) вывода(печать) двумерного массива
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)   ///// Заполняем массив (двумерный) рандомными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
*/
/////////////////////////////////////////////////////////////////////////////////////////
/*
int[,] pic = new int[,]
{
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
    {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};
void PrintImage(int[,] image) // Метод убираем лишние нули и замещаем на плюсы
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            //Console.Write($"{matr[i, j]} ");
            if (image[i, j] == 0) Console.Write($" "); // если в цикле будет нуль меняем его на пробе
            else Console.Write($"+"); // иначе вставляем плюс
        }
        Console.WriteLine();
    }
}
void FillImage(int row, int col)  /// Метод закрашивания  (int row, int col) точки с которых начинаем стартовать (нужно попасть во внутрь картинки)
{
    if (pic[row, col] == 0) // если пиксель в данной точке равен нулю т.е. не закрашен
    {
        pic[row, col] = 1; // мы данный пиксель закрашиваем (в данновм случае 1 (еденичкай))
        FillImage(row - 1, col); // поднимаемся на строчку выше
        FillImage(row, col - 1); // в тойже строке в лево
        FillImage(row + 1, col); // идем в низ на след строку 
        FillImage(row, col + 1); // идем в право в тойже строке
    }
}
PrintImage(pic);
FillImage(13, 13);
PrintImage(pic);
*/
////////////////////////////////////////////////////////////////////////
/// Рекурсия
 /*
int Factorial(int n) ///// метод для вычесления факториала
{
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1; // если факториал равен 1 то возвращаем 1
    else return n * Factorial(n-1); // иначе возвращаем число n-факториал * на n-факториал - 1-предыдущего числа
} 
Console.WriteLine(Factorial(5)); // выводим на экран фактрориал 3! = 3*2*1 = 6
*/
/*
double Factorial(int n) /// меняе тип данных int на double для большего значений чисел
{
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
*/
/////////////////////////////////////////

// Фибоначи - задается следующее число через предыдущее f(n)=f(n-1)+f(n-2)
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1)+f(n-2)
// 1 1 2 3 5 8 13 21 34 55 ....

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f{i} = {Fibonacci(i)}");
}
