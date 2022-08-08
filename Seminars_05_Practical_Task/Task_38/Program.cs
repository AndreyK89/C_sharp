/* Выполнил Кошелев Андрей/ Группа GU | Разработчик | 2789
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/


Console.Write("Введите размер массива: ");
int size = int.Parse(System.Console.ReadLine());
double[] Array = new double[size];
Random rnd = new Random();


for (int i = 0; i < Array.Length; i++)
{
    Array[i] = Math.Round(rnd.NextDouble() * size, 2);
}

Console.WriteLine("Массив вещественных чисел : [ {0} ] ", String.Join(" | ", Array));
SelectionMaxMinSortItemArray(Array);
Console.WriteLine("Max элемент массива : " + Array[0]);
Console.WriteLine("Min элемент массива: " + Array[Array.Length - 1]);
Console.Write("Разница между Max и Min элементами массива = ");
Console.Write(Math.Round(Array[0] - Array[Array.Length - 1], 2));
Console.WriteLine();


void SelectionMaxMinSortItemArray(double[] array)
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxElement = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxElement]) maxElement = j;

        }
        Swap(ref array[maxElement], ref array[i]);
    }

}

void Swap(ref double leftItem, ref double rightItem)
{
    double temp = leftItem;
    leftItem = rightItem;
    rightItem = temp;
}
