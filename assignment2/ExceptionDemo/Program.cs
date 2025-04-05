using System;
using MyOperations;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations op = new Operations();

            try
            {
                // Test divide
                Console.WriteLine("Dividing 10 by 0:");
                int result = op.Divide(10, 0);
                Console.WriteLine($"Result: {result}");
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine($"Error Code: {ex.ErrorCode}, Message: {ex.Message}");
            }

            try
            {
                // Test array
                int[] arr = { 1, 2, 3 };
                Console.WriteLine("Accessing index 5:");
                int element = op.GetElement(arr, 5);
                Console.WriteLine($"Element: {element}");
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine($"Error Code: {ex.ErrorCode}, Message: {ex.Message}");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
