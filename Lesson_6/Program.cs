// Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)


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

// int[] ReverseArray(int[] array)
// {
//     for (int i = 0, j = array.Length -1; i < j; i++,j--)
//     {   
//         int temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;
//     }
//     return array;
// }

// Console.Write("Input size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());


// Console.Write("Input min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());


// Console.Write("Input max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size,min,max);
// ShowArray(myArray);

// myArray = ReverseArray(myArray);
// ShowArray(myArray);

// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.

// bool Possible(int num1, int num2, int num3)
// {   
//     bool result = true;
//     if (num1 > num2 + num3 && num2 > num1 + num3 && num3 > num1 + num2) 
//     {   
//         result = false;
//     }
//     return result;
// }

// Console.Write("Введите размер стороны a треугольника");
// int a = Convert.ToInt32(Console.ReadLine());


// Console.Write("Введите размер стороны b треугольника");
// int b = Convert.ToInt32(Console.ReadLine());



// Console.Write("Введите размер стороны c треугольника");
// int c = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Possible(a,b,c));

// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: a и b.

// void Fibonachi(int a, int b, int n)

// {   
//     Console.Write($"{a} {b} ");
//     int temp = 0;
//     for (int i = 0; i < n; i++)
//         {
//             temp = a + b;
//             a = b;
//             b = temp;
//             Console.Write($"{b} ");

//         }
// }

// Console.Write("Введите первый элемент Фибонначи");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второй элемент Фибонначи");
// int num2 = Convert.ToInt32(Console.ReadLine());


// Console.Write("Введите количество элементов");
// int n = Convert.ToInt32(Console.ReadLine());

// Fibonachi(num1,num2,n);


// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.

string Binary(int num)
{
    string elem = string.Empty;

    while(num > 0)
    {
        int n = num % 2;
        elem = Convert.ToString(n) + elem;
        num = num / 2;
    }
    return elem;
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string result  = Binary(n);
Console.WriteLine(result);