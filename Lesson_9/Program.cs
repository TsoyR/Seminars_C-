// Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNums(int n)
{
    if (n  > 1) ShowNums(n -1);

    Console.Write(n + " ");
}

ShowNums(5);
*/

// Напишите программу, которая будет 
// принимать на вход число и возвращать сумму его цифр.

int SumofDigit(int n)
{
    if (n > 0) return SumofDigit(n/10) + n % 10;
    else return 0;
}

Console.WriteLine(SumofDigit(5364));

// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.

void ShowNum(int m, int n)
{
    if (n > m ) ShowNum(m, n - 1);
    Console.Write(n + " ");
}
ShowNum(5,10);

// Напишите программу, которая на вход принимает два числа A и B, и 
// возводит число А в целую степень B с помощью рекурсии.

int PowVal(int a, int b)
{
    if (b > 1) return PowVal(a,b-1)*a;
    else return a;
}

Console.WriteLine(PowVal(2,3));