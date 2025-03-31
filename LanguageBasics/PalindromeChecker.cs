using System;

class PalindromeChecker
{
    public static void RunPalindromeChecker()
    {
        Console.Write("\nEnter an integer: ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int number) || number < 0)
        {
            Console.WriteLine("Invalid input! Please enter a positive integer.");
            return;
        }

        bool isPalindromeIterative = IsPalindromeIterative(number);
        bool isPalindromeRecursive = IsPalindromeRecursive(input, 0, input.Length - 1);

        Console.WriteLine($"Using Iteration: {number} is " + (isPalindromeIterative ? "a Palindrome." : "not a Palindrome."));
        Console.WriteLine($"Using Recursion: {number} is " + (isPalindromeRecursive ? "a Palindrome." : "not a Palindrome."));
    }

    // Palindrome check using iteration
    private static bool IsPalindromeIterative(int num)
    {
        int original = num, reversed = 0;
        while (num > 0)
        {
            int digit = num % 10;
            reversed = reversed * 10 + digit;
            num /= 10;
        }
        return original == reversed;
    }

    // Palindrome check using recursion
    private static bool IsPalindromeRecursive(string str, int left, int right)
    {
        if (left >= right)
            return true;
        if (str[left] != str[right])
            return false;
        return IsPalindromeRecursive(str, left + 1, right - 1);
    }
}
