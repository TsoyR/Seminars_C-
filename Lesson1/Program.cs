/*Console.Write("Input number: ");


int number = Convert.ToInt32(Console.ReadLine());

int kvadrat = number * number;
//Console.WriteLine("The quard of " + number + " is " + kvadrat);
Console.WriteLine($"The quard of {number} is {kvadrat}");
*/

Console.Write("Input number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Inpur number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2)
{
    Console.WriteLine($"{number1} is quard of {number2}");
}
else
{
    Console.WriteLine($"{number1} not is quard of {number2}");
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = number * (-1);

while (current < number)
{
    Console.Write(current + " ");
    current ++;
}


