using System;

class StringManipulator
{
    public static void RunStringManipulation()
    {
        Console.Write("\nEnter a string: ");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input) || input.Length < 2)
        {
            Console.WriteLine("The string must have at least two characters.");
        }
        else
        {
            string shuffledString = SwapFirstAndLast(input);
            Console.WriteLine("Shuffled string: " + shuffledString);
        }
    }

    private static string SwapFirstAndLast(string str)
    {
        char[] charArray = str.ToCharArray();
        char temp = charArray[0];
        charArray[0] = charArray[^1]; // Swapping first and last character
        charArray[^1] = temp;

        return new string(charArray);
    }
}
