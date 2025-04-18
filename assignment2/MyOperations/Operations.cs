﻿using System;

namespace MyOperations
{
    public class Operations
    {
        public int Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {
                throw new MyCustomException(101, "Cannot divide by zero.");
            }
        }

        public int GetElement(int[] arr, int index)
        {
            try
            {
                return arr[index];
            }
            catch (IndexOutOfRangeException)
            {
                throw new MyCustomException(102, "Index is out of range.");
            }
        }
    }
}
