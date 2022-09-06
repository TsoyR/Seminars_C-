// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// int[]CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];

//     for(int i = 0; i < size; i++)
//         newArray[i] = new Random().Next(minValue, maxValue + 1);

//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// int CountEvenNum(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] % 2 == 0) count++;
//     return count;    
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите минимальное трехзначное число диапазона: ");
// int min = Convert.ToInt32(Console.ReadLine());


// Console.Write("Введите максимальное трехзначное число диапазона: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[]myarray1 = CreateRandomArray(size,min,max);
// ShowArray(myarray1);

// Console.WriteLine($"Количество четных чисел в массиве равно {CountEvenNum(myarray1)}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[]CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];

//     for(int i = 0; i < size; i++)
//         newArray[i] = new Random().Next(minValue, maxValue + 1);

//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// int SumOddNum(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (i % 2 != 0) sum += array[i];
//     return sum;    
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите минимальное значение диапазона: ");
// int min = Convert.ToInt32(Console.ReadLine());


// Console.Write("Введите максимальное значение диапазона: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[]myarray2 = CreateRandomArray(size,min,max);
// ShowArray(myarray2);

// Console.WriteLine($"Сумма элементов стоящих на нечетных позициях равна {SumOddNum(myarray2)}");

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[]CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] newArray = new double[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();

    return newArray;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

double Max(double[] array)
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max) max = array[i];
        
    return max;    
}

double Min(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] < min) min = array[i];

    return min;    
}


Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение диапазона: ");
int min = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите максимальное значение диапазона: ");
int max = Convert.ToInt32(Console.ReadLine());

double[]myarray3 = CreateRandomArray(size,min,max);
ShowArray(myarray3);

Console.WriteLine($"Разница между {Max(myarray3)} и {Min(myarray3)} равна {Max(myarray3) - Min(myarray3)}");
