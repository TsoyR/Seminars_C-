// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

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

// int FindPositiveSum(int[] array)
// {
//     int sum = 0; 
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] > 0) sum += array[i];

//     return sum;
// }


// int FindNegativeSum(int[] array)
// {
//     int sum = 0; 
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] < 0) sum += array[i];

//     return sum;
// }


// Console.Write("Input size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());


// Console.Write("Input min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());


// Console.Write("Input max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size,min,max);
// ShowArray(myArray);

// int positiveSum = FindPositiveSum(myArray);
// int negativeSum = FindNegativeSum(myArray);

// Console.WriteLine($"Sum of positive elements is {positiveSum} \nSum of negative elements is {negativeSum}");



// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные,
// и наоборот.


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


// int[] Swap (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= (-1);

//     }
//     return array;
// }

// int[] meArray = CreateRandomArray(10,-10,10);
// ShowArray(meArray);
// ShowArray(Swap(meArray));


// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

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


// bool NumCheck(int[] array, int findnum)
// {   

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == findnum) return true;
        
//     }
//     return false;

// }


// Console.Write("Enter number: ");
// int findnum = Convert.ToInt32(Console.ReadLine());
// int[]myArray = CreateRandomArray(10,1,100);
// ShowArray(myArray);
// Console.WriteLine($"{NumCheck(myArray,findnum)}");


// Задайте одномерный массив из 12 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// int DoubleDigit(int[] array)
// {   
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 10 && array[i] < 100) count++;
        
//     }
//     return count;
// }
// int[]myArray = CreateRandomArray(12,-100,120);
// ShowArray(myArray);
// Console.WriteLine($"Count of double digit is {DoubleDigit()}");


// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

int[]CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] ProdNum(int[] array)

{   

    if (array.Length/2 == 0)
    {   
        int size = array.Length;
        for (int i = 0; i < array.Length/2; i++)
            array[i] = array[i] * array[array.Length - count] ;
            count++;
    }

    else 
    {
        int size = array.Length;
        for (int i = 0; i < array.Length/2; i++)
            array[i] = array[i] * array[array.Length - count];
            array[array.Length/2 + 1] = array[array.Length/2 + 1];
    }
    
    
    return array;
}

int[]myArray = CreateRandomArray(5,1,5);
ShowArray(myArray);

Console.WriteLine($"Произведение сосед чисел {ProdNum(myArray)}");





