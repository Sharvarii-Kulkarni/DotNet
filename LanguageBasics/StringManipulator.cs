using System;

public class StringManipulator
{
    public static void Run()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input) || input.Length < 2)
        {
            Console.WriteLine("The string must have at least two characters.");
            return;
        }

        // Swap first and last characters
        char first = input[0];
        char last = input[input.Length - 1];
        string middle = input.Substring(1, input.Length - 2);

        string result = last + middle + first;
        Console.WriteLine("Shuffled string: " + result);
    }
}
