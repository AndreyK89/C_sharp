/* Задача 40: Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины.
(Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон).
*/


bool isTriangle(int a, int b, int c)
{
    if (a + b > c && c + b > a && a + c > b)
    {
        return true;
    }
    else
    {
        return false;
    }
}

System.Console.WriteLine("Введите 1 число");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите 2 число");
int b = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите 3 число");
int c = int.Parse(Console.ReadLine());

if (isTriangle(a, b, c))
{
    System.Console.WriteLine("Треугольник существует");
}
else
{
    System.Console.WriteLine("Треугольник несуществует");
}
