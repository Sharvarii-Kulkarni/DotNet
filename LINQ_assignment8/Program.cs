using System;

namespace LinqDemo
{
    internal static class Program
    {
        static void Main()
        {
            Console.WriteLine("LINQ Demonstrations:\n");

            // Call each LINQ demonstration
            //LinqToArray.Run();

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

            //  LinqToXml.Run();
            //LinqToSql.Run();
            //  LinqToCollection.Run();
        }

    }
}
