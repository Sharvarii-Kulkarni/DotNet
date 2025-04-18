using System;

class SquareRootCalculator
{
    public static void Run()
    {
        try
        {
            Console.Write("\nEnter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            if (number < 0)
                throw new ArgumentException("Error: Square root of a negative number is not defined for real numbers.");

            double sqrt = Math.Sqrt(number);
            Console.WriteLine($"Square root of {number} is {sqrt:F2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}
