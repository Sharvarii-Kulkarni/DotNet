using System;
using System.Linq;

namespace LinqDemo
{
    public class LinqToArray
    {
        public static void Run()
        {
            int[] numbers = { 10, 25, 17, 5, 30, 22 };

            var evenNumbers = from num in numbers
                              where num % 2 == 0
                              select num;

            Console.WriteLine("Even Numbers in Array:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
        }
    }
}
