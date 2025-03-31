using System;
using MyOperations;  // Import Class Library

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter numerator: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Enter denominator: ");
            int denom = int.Parse(Console.ReadLine());

            int result = Operations.Divide(num, denom);
            Console.WriteLine($"Result: {result}");
        }
        catch (MyCustomException ex)
        {
            Console.WriteLine($"Custom Exception Caught! \nError Code: {ex.ErrorCode}\nMessage: {ex.Message}");
        }

        try
        {
            int[] numbers = { 1, 2, 3 };
            Console.Write("Enter index to fetch: ");
            int index = int.Parse(Console.ReadLine());

            int value = Operations.GetElement(numbers, index);
            Console.WriteLine($"Value at index {index}: {value}");
        }
        catch (MyCustomException ex)
        {
            Console.WriteLine($"Custom Exception Caught! \nError Code: {ex.ErrorCode}\nMessage: {ex.Message}");
        }

        Console.WriteLine("Program execution completed.");
    }
}
