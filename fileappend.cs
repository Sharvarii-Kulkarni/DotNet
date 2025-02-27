using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "abc.txt";

        Console.Write("Enter text to add in file ");
        string input = Console.ReadLine();

        File.AppendAllText(filePath, input + Environment.NewLine);

        Console.WriteLine("Text added successfully!");
    }
}
