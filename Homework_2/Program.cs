//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

/*

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int number)
{
    int num = number / 10;
    int result = num % 10;
    return result;

}

int num_result = SecondDigit(number);
Console.WriteLine($"Second digit of number {number} is {num_result}");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6


Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());


void ThirdDigit(int number)
{
    int whole_number = number / 10;
    while (whole_number < 99 && whole_number > 9)
    {
    
        whole_number = number / 10;
        break;
    }
    if (whole_number < 9)
    {
        Console.WriteLine("Нет такой цифры");
    }
    else
    {
    int res = number % 10;
    Console.WriteLine(res);
    }    
    
}




ThirdDigit(number);

/*

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.Write("Input day of the week: ");
int number = Convert.ToInt32(Console.ReadLine());

void Weekend(int number)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine($"The number {number} is weekend");
    }
    else
    {
        Console.WriteLine($"The number {number} is not weekend");
    }

}

Weekend(number);
*/