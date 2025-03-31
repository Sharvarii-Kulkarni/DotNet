using System;

class DigitSumCalculator
{
    public static void RunDigitSumCalculator()
    {
        Console.Write("\nEnter an integer: ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int number) || number < 0)
        {
            Console.WriteLine("Invalid input! Please enter a positive integer.");
            return;
        }

        int sum = CalculateDigitSum(number);
        Console.WriteLine($"Sum of digits: {sum}");
    }

    private static int CalculateDigitSum(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10; // Extract the last digit and add to sum
            num /= 10;       // Remove the last digit
        }
        return sum;
    }
}
