// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// int FindPow(int a, int b)
// {
//     int factor = a;
//     for (int count = 1; count <= b-1; count ++) 
//     a = factor * a + count * 0;
//     return a;
// }

// Console.Write("Введите число: ");
// int baseofnumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите степень числа: ");
// int power = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Возведение числа {baseofnumber} в степень {power} будет число {FindPow(baseofnumber,power)}");

// Задача 27: Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// int SumofNum(int number)
// {   
//     int sum = 0;
//     int sumofdigit = 0;
//     while ( number!= 0)
//     {
//         sumofdigit = number % 10;
//         sum = sum + sumofdigit; 
//         number = number / 10;    
//     }
//     return sum;
// }

// Console.WriteLine("Введите число : ");
// int s = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма цифр числа {s} - {SumofNum(s)}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и
// выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int []CreateArray(int size)
{
    int[]newArray = new int[size];
    int i;
    for (i = 0; i < size; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i} - ");
        int elem = Convert.ToInt32(Console.ReadLine());
        newArray[i] = elem;
    }

    return newArray;

}

void ShowArray(int[]array)
{
    for( int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Введите количество элементов массива: ");
int count = Convert.ToInt32(Console.ReadLine());
ShowArray(CreateArray(count));