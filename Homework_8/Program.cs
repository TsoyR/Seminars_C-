// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/*

int[,] CreateRandom2dArray()
{   
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

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

int[,] SortArray (int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int run = 0; run < columns; run++)
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < columns - 1; j++ )
                {   
                    int temp = array[i,j]; 
                    if (array[i,j] < array[i,j+1])
                    {
                        array[i,j] = array[i,j+1];
                        array[i,j+1] = temp;        
                    }         
                }           
    return array;
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
int [,] myArr = SortArray(newArray);
Show2dArray(myArr);

*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
int[,] CreateRandom2dArray()
{   
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

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

void MinRow (int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int temp = 0;
    int[] temparray = new int[columns];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++ )
            {
                temp += array[i,j];                               
            }
        temparray[i] = temp;
        temp = 0;    
    }
    int min = temparray[0];
    int pos = 0;
    for (int k = 0; k < temparray.Length; k++)
    {
        if (temparray[k] < min )
        {
            min =  temparray[k];
            pos = k;    
        }
       
    }
    Console.WriteLine($"номер строки с наименьшей суммой элементов: {pos + 1} строка");
            
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
MinRow(newArray);
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
/*

int[,] CreateRandom2dArray()
{   
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

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


int [,] Matrix(int[,]array1, int[,]array2)
{
    int row1 = array1.GetLength(0);
    int column1 = array1.GetLength(1);    
    int row2= array2.GetLength(0);
    int column2 = array2.GetLength(1);
    int [,] C = new int [row1,column2];
    if (column1 != row2)
    Console.WriteLine("Матрицы не совпадают");
    else
    {
        for (int i = 0; i < row1; i++)
        {
            for (int j = 0; j < column2; j++)
            {
                
                for (int k = 0; k < row1; k++)
                {
                    C[i,j] += array1[i,k]*array2[k,j];
                }
            }      
    
        }
    }
    return C;    
    
}


int[,] newArray1 = CreateRandom2dArray();
Show2dArray(newArray1);
int[,] newArray2 = CreateRandom2dArray();
Show2dArray(newArray2);
int[,] M = Matrix(newArray1,newArray2);
Show2dArray(M);
*/


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


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


int[,] MatrixSpiral()
{
    Console.Write("Input number of rows: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int column = Convert.ToInt32(Console.ReadLine());
    int[,] Spiral = new int[row,column];
    int startCol = 0;
    int endCol = row - 1;
    int startRow = 0;
    int endRow = column - 1;
    int count = 1;

    while (startCol <= endCol && startRow <= endRow)
    {
        for (int j = startCol; j <= endCol;j++)
        {
        Spiral[startRow,j] = count;
        count++;
        }
        startRow++;

        for (int i = startRow; i <= endRow; i++)
        {
        Spiral[i,endCol] = count;
        count++;
        }
        endCol--;
        for (int k = endCol; k >= startCol; k--)
        {
        Spiral[endRow,k] = count;
        count++;
        }
        endRow--;
        for (int l = endRow; l >= startRow; l--)
        {
        Spiral[l,startCol] = count;
        count++;
        }
        startCol++;
        
    }
    return Spiral;
}

int[,] s = MatrixSpiral();
Show2dArray(s);


