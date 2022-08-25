/* Выполнил Кошелев Андрей/ Группа GU | Разработчик | 2789 |
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
m = 2, n = 3 -> A(m,n) = 9
*/


int m = Akkerman("M");
int n = Akkerman("N");
Console.WriteLine($"Функция Аккермана -> A({m},{n}) = {Akerman(m, n)}");

static int Akerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
        if ((n != 0) && (m == 0))
        return Akerman(n - 1, 1);
    else
        return Akerman(n - 1, Akerman(n, m - 1));
}

static int Akkerman(string name)
{
    Console.Write($"Введите число {name}: ");
    return int.Parse(Console.ReadLine());
}
