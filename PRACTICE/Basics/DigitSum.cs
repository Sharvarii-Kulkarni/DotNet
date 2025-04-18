using System;

public class DigitSum
{
	public static void Run()
	{
        try
        {
            Console.WriteLine("Enter a number");
			int number = Convert.ToInt32(Console.ReadLine());

			if (number < 0)
			{
				Console.WriteLine("Enter a positive number");
				return;
			}
			
			int sum = 0;

			while (number > 0)
			{

				int digit = number % 10;
				sum = sum + digit;

				number = number / 10;
				
			}
            Console.WriteLine($"Sum of digits is {sum}");

        }
		catch
		{
			Console.WriteLine("Invalid input");
		}
	}
}
