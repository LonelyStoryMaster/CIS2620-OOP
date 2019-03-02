using System;
using static System.Console;

public class NestedIfs
{
    static void Main()
    {
        string input;
        int[] numbers = { 0, 0, 0 };
        for (int i = 0; i < numbers.Length; i++)
        {
            Write("Enter an integer: ");
            input = ReadLine();
            numbers[i] = Convert.ToInt32(input);
        }

        if (numbers[0] == numbers[1])
        {
            if (numbers[0] == numbers[2])
            {
                WriteLine("All three numbers are equal");
            }
            else
            {
                WriteLine("The first and second numbers are equal");
            }
        }
        else if (numbers[0] == numbers[2])
        {
            WriteLine("The first and the last numbers are equal");
        }
        else if (numbers[1] == numbers[2])
        {
            WriteLine("The second and third numbers are equal");
        }
        else
        {
            WriteLine("None of the numbers are equal to another");
        }
    }
}
