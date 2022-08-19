/*Задача 69: Напишите программу, которая на вход принимает два числа A и B,
и возводит число А в целую степень B 
с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
и возводит число А в целую степень B 
с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵
A = 2; B = 3 -> 8
*/


Console.Clear();
Console.WriteLine("Введите число А");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите степень B");
int B = int.Parse(Console.ReadLine());

Console.WriteLine($"{A} в степени {B} =  {Power(A, B)}");


double Power(int N, int P)
{
    if (P == 1)
    {
        return N;
    }
    if (P == 0)
    {
        return 1;
    }
    if (P < 0)
    {
        return 1 / Power(N, (-1 * P));
    }

    return N * Power(N, --P);
}
