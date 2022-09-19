
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*

int SumElement(int m, int n)
{
    if(m < n) return SumElement(m,n-1)+n;
    else return m; 
}
Console.WriteLine(SumElement(4,8));
*/
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

int AckermanFunc(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return AckermanFunc(m - 1, 1);
    return AckermanFunc(m - 1, AckermanFunc(m, n - 1));
}

Console.WriteLine(AckermanFunc(2,3));