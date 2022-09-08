// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


// Console.Write("Введите количество чисел: ");
// int count = Convert.ToInt32(Console.ReadLine());
// int nozero = 0;
// while(count > 0)
// {   
//     Console.Write("Введите число - ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     if (num > 0) nozero ++; 
//     count --;
// }
// Console.WriteLine($"Количество чисел больше нуля равно {nozero}");



// Задача 43: Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



void Intersection(double b1, double k1 , double b2, double k2)
{
    if (k1 == k2) Console.WriteLine("Прямые парралельны");
    
    else
    {
        double x = -(b1 - b2) / (k1 - k2);
        double y = k2 * x + b2;
        Console.WriteLine($"Точка пересечения двух прямых имеет координаты ({x} ; {y})");
    }
}

Console.Write("Введите b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2:");
double k2 = Convert.ToDouble(Console.ReadLine());

Intersection(b1,k1,b2,k2);