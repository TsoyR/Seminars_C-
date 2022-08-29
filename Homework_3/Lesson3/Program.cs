// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

/*
Console.Write("Input number");
int number = Convert.ToInt32(Console.ReadLine());

void Palindrom(int number)
{
    int reverse = 0;
    int num = number;
    while (num != 0)
    {   
        int remainder = num % 10;
        reverse = reverse * 10 + remainder;
        num = num / 10;
    }

    if (number == reverse)
    {
        Console.WriteLine($"Число {number} паллиндром");
    }
    else Console.WriteLine($"Число {number} не паллиндром");

}          

    
Palindrom(number);

*/

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53   

/*

double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 -z1) * (z2 - z1));
}

Console.Write("Введите координаты первой точки x1 = ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты первой точки y1 = ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты первой точки z1 = ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты второй точки x2 = ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты второй точки y2 = ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты второй точки z2 = ");
double z2 = Convert.ToDouble(Console.ReadLine());

double dist = FindDistance(x1,y1,z1,x2,y2,z2);
Console.WriteLine($"Расстояние между точками равно {dist}");

*/


// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


void Cube(int n)
{
    int i = 1;
    while ( i <= n)
    {
        
        Console.WriteLine($"Число {i} в кубе {i*i*i}");
        i++;
        
    }
    
}

Console.Write("Введите число");
int cube_of_n = Convert.ToInt32(Console.ReadLine());
Cube(cube_of_n);
