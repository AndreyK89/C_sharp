/* 
Выполнил Кошелев Андрей/ Группа GU | Разработчик | 2789 |
Напишите программу, которая на вход принимает три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int a, b, c;
        Console.Write("Введите первое число: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        b = int.Parse(Console.ReadLine());
        Console.Write("Введите третье число: ");
        c = int.Parse(Console.ReadLine());

int max = a;
    if (b > a)
    max = b;
    if (c > max)
    max = c;

        Console.WriteLine("Максимальное число " + max);
