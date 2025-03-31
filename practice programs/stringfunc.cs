//Take input in string and make use of atleast 4 string functions , also find the no of items l is present in the string along with the position
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine(); // Taking input as a string

        string upperCase = input.ToUpper();
        Console.WriteLine("Upper Case: " + upperCase);

        string lowerCase = input.ToLower();
        Console.WriteLine("Lower Case: " + lowerCase);

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);
        Console.WriteLine("Reversed String: " + reversed);

        //Replace spaces with dashes (for demonstration)
        string replacedString = input.Replace(" ", "-");
        Console.WriteLine("Replaced String (spaces -> '-'): " + replacedString);

        // Finding occurrences of 'l' and their positions
        int count = 0;
        Console.Write("Positions of 'l': ");
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'l')
            {
                Console.Write(i + " "); // Printing index of 'l'
                count++;
            }
        }
        Console.WriteLine("\nTotal count of 'l': " + count);

        // Formatting output with '*' between letters
        string formattedOutput = string.Join("*", input.ToCharArray());
        Console.WriteLine("Formatted Output: *" + formattedOutput + "*");
    }
}
