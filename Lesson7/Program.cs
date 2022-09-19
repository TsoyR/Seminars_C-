// Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.

// int[,] CreateRandom2Array(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             newArray[i,j] = new Random().Next(minValue,maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
        
//         }
//         Console.WriteLine();

//     }
//     Console.WriteLine();
// }

// Console.Write("Input number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] newArray = CreateRandom2Array(m, n, min, max);
// Show2dArray(newArray);


// Задайте двумерный массив размера m на n, каждый элемент
// в массиве находится по формуле: Aij = i+j.
// Выведите полученный массив на экран.

// int[,] CreateRandom2Array(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             newArray[i,j] = i + j;
//         }
//     }
//     return newArray;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
        
//         }
//         Console.WriteLine();

//     }
//     Console.WriteLine();
// }

// Console.Write("Input number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());


// Console.Write("Input number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] newArray = CreateRandom2Array(m, n, min, max);
// Show2dArray(newArray);

// Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, и замените эти элементы на их квадраты.

/*

int[,] CreateRandom2Array(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue,maxValue + 1);
        }
    }
    return newArray;
}

int[,] SwitchQuard(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i += 2)
    {
        for(int j = 0; j < array.GetLength(1); j+=2)
        {
            if (i % 2 == 0 && j % 2 == 0) array[i,j] = array[i,j] * array[i,j];
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        
        }
        Console.WriteLine();

    }
    Console.WriteLine();
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());


Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2Array(m, n, min, max);
Show2dArray(newArray);
Console.WriteLine();
int[,] switcharray = SwitchQuard(newArray);
Show2dArray(switcharray);
*/

// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)


int[,] CreateRandom2Array(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue,maxValue + 1);
        }
    }
    return newArray;
}

int FindSum(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0) &&  i < array.GetLength(1); i++)
    {
        sum+= array[i,i];
    }
    return sum;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        
        }
        Console.WriteLine();

    }
    Console.WriteLine();
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());


Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2Array(m, n, min, max);
Show2dArray(newArray);
Console.WriteLine();
int sumarray = FindSum(newArray);
Console.WriteLine($"Сумма элементов по диагонали равна {sumarray}");