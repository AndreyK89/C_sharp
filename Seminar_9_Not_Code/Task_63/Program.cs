/* Задача 63: Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

void NaturalNum(int start, int end)
{
    if (start > end)
    {
        return;
    }
    Console.Write(start + "\t");
    start++;
    NaturalNum(start, end);
}


Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
NaturalNum(1, n);
