using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filepath = "output.txt";

        while (true)
        {
            Console.WriteLine("1. Write\n2. Read\n3.Append\nChoose operation: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter text to write into file: ");
                    string content = Console.ReadLine();
                    File.WriteAllText(filepath, content);
                    Console.WriteLine("Written");
                    break;
                case "2":
                    if (File.Exists(filepath))
                    {
                        Console.WriteLine("Reading file...");
                        string filetxt = File.ReadAllText(filepath);  // Reads content of file
                        Console.WriteLine(filetxt);
                    }
                    else
                    {
                        Console.WriteLine("File does not exist.");
                    }
                    break;
                case "3":
                    Console.WriteLine("Enter text to append in file:");
                    string appn = Console.ReadLine();

                    File.AppendAllText(filepath, appn);

                    Console.WriteLine("Appended, to check- chose option 2");
                    break;
            }
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}