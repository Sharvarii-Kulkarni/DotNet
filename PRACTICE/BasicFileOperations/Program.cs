class Program
{
    static void Main()
    {
        Console.WriteLine("Enter text to write in file: ");
        string text = Console.ReadLine();

        File.WriteAllText("output.txt", text);

        Console.WriteLine("text added in file");

        Console.WriteLine("Reading file contents: ");
        string content = File.ReadAllText("output.txt");

        Console.WriteLine(content);
    }
}