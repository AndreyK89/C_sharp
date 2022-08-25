/*  Выполнил Кошелев Андрей/ Группа GU | Разработчик | 2789 |
Задача 64: Задайте значения M и N. Напишите программу,
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 5, 6, 7, 8""
*/


int m = Input("Введите значение M: ");
int n = Input("Введите значение N: ");

int Input(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

Console.WriteLine("Натуральные числа от M до N:");
OutputNumbers(m, n);

void OutputNumbers(int m, int n)
{
    if (m > n) return;

    else
    {
        Console.Write(m + " ");
        OutputNumbers(++m, n);
    }
}
