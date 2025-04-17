class Program
{
    static void Main()
    {
        Console.WriteLine("Enter any sentence: ");
        string sentence = Console.ReadLine();

        int wordcount = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;

        int charcount = sentence.Length;

        Console.WriteLine($"The word count is: {wordcount}");
        Console.WriteLine($"The character count is: {charcount}");
    }
}