using System;

namespace MyOperations
{
    // Custom Exception Class
    public class MyCustomException : Exception
    {
        public int ErrorCode { get; } // Error Code Property

        public MyCustomException(int errorCode, string message) : base(message)
        {
            ErrorCode = errorCode;
        }
    }

    public class Operations
    {
        // Function to demonstrate DivideByZeroException
        public static int Divide(int a, int b)
        {
            try
            {
                return a / b;  // This can throw DivideByZeroException
            }
            catch (DivideByZeroException)
            {
                throw new MyCustomException(101, "Error: Division by zero is not allowed.");
            }
        }

        // Function to demonstrate IndexOutOfRangeException
        public static int GetElement(int[] arr, int index)
        {
            try
            {
                return arr[index];  // This can throw IndexOutOfRangeException
            }
            catch (IndexOutOfRangeException)
            {
                throw new MyCustomException(102, "Error: Index out of range.");
            }
        }
    }
}
