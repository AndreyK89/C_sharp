/*Задача 65: Задайте значение N. Напишите функцию,
которая выведет все натуральные числа в промежутке от N до 0.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8"
*/

/*
Console.WriteLine("Введите число N ");
int n = int.Parse(Console.ReadLine());
Naturalback(n);

void Naturalback(int start)
{
    if (start < 0)
    {
        return;
    }
    Console.Write(start + "\t");
    start--;
    Naturalback(start);
}

*/

Console.WriteLine("Введите число N ");
int n = int.Parse(Console.ReadLine());
//Console.WriteLine(--n);
Console.Write(Naturalback(n, " "));

string Naturalback(int start, string res)
{
    if (start < 0)
    {
        return res;
    }
    //Console.Write(start + "\t"+ Naturalback(start--));
    return ($"{start}  \t {Naturalback(--start, res)} ");
 }
