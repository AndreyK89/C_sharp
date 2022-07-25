/* 
Выполнил Кошелев Андрей/ Группа GU | Разработчик | 2789 |
Напишите программу, которая на вход принимает два числа и выдаёт максимальное из этих чисел.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

 int a, b;
        Console.Write("Введите первое число: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        b = int.Parse(Console.ReadLine());
 
        if (a > b)
        {
            Console.WriteLine("Максимальное число " + a);
        }
        else
        {
            Console.WriteLine("Максимальное число " + b);
        }     
