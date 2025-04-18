using System;

public class PalindromeChecker
{
    public static void Run()
    {
        Console.WriteLine("Enter a number:");
        string input = Console.ReadLine();

        // Input validation
        if (!int.TryParse(input, out int number) || number < 0)
        {
            Console.WriteLine("Invalid input! Please enter a positive number.");
            return;
        }

        // Check using iteration
        bool isIterative = IsPalindromeIterative(number);

        // Check using recursion
        bool isRecursive = IsPalindromeRecursive(input, 0, input.Length - 1);

        // Output results
        Console.WriteLine($"Using Iteration: {number} is " + (isIterative ? "a Palindrome." : "not a Palindrome."));
        Console.WriteLine($"Using Recursion: {number} is " + (isRecursive ? "a Palindrome." : "not a Palindrome."));
    }

    // Method to check palindrome using iteration
    private static bool IsPalindromeIterative(int num)
    {
        int original = num;
        int reversed = 0;

        while (num > 0)
        {
            int digit = num % 10;
            reversed = reversed * 10 + digit;
            num /= 10;
        }

        return original == reversed;
    }

    // Method to check palindrome using recursion
    private static bool IsPalindromeRecursive(string str, int left, int right)
    {
        if (left >= right)
            return true;

        if (str[left] != str[right])
            return false;

        return IsPalindromeRecursive(str, left + 1, right - 1);
    }
}
