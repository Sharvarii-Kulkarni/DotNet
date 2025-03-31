using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo
{
    public class LinqToCollection
    {
        public static void Run()
        {
            List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Alex" };

            var filteredNames = from name in names
                                where name.StartsWith("A")
                                select name;

            Console.WriteLine("Names starting with 'A':");
            foreach (var name in filteredNames)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
        }
    }
}
