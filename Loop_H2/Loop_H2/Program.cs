using System;

// Program 1
Console.WriteLine("Program 1");
Console.WriteLine();

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
}

// Program 2
Console.WriteLine();
Console.WriteLine("Program 2");
Console.WriteLine();

int u = 0;
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
    u += i;
    if (i == 10)
    {
        Console.WriteLine("Sum = " + u);
    }
}

// Program 3
Console.WriteLine();
Console.WriteLine("Program 3");
Console.WriteLine();

int[] numbers = new int [2];
for (int i = 0; i < numbers.Length;)
{
    Console.WriteLine("Type in a whole number");
    try
    {
        numbers[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
Console.WriteLine(numbers[0] * numbers[1]);

Console.ReadLine();