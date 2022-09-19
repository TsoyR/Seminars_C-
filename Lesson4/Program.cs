int FindSum(int num)
{
    int sum = 0;

    for(int current = 1; current <= num; current ++)
        sum += current;
    
    return sum;
}
Console.Write("Input positive integer number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of numbers from 1 to {a} is {FindSum(a)}");

//Напишите программу, которая принимает на вход число и
// выдаёт количество цифр в числе.
int Size(int number)
{   
    int size = 0;
    while (number > 0)
    {
        number = number / 10;
        size ++;

    }
    return size;

}
    

Console.WriteLine("Посчитаем количество цифр");
Console.Write("Input number : ");
int num = Convert.ToInt32(Console.ReadLine());
int sizeofnum = Size(num);
Console.WriteLine($"В числе {num} - {sizeofnum} цифр");



//Напишите программу, которая принимает на вход число N и 
//выдаёт произведение чисел от 1 до N.


int FindProductofNum(int num)
{
    int fac = 1;

    for(int current = 2; current <= num; current ++)
        fac *= current;
    
    return fac;
}

Console.Write("Input positive integer number");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Product of numbers from 1 to {b} is {FindProductofNum(b)}");



