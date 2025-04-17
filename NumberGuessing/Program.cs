class Program()
{
    static void Main()
    {
        Random random = new Random();
        int TargetNumber = random.Next(1, 101);
        int attempts = 0;

        while (true)
        {
            Console.WriteLine("Guess the number from 1-100");
            int num = Convert.ToInt32(Console.ReadLine());
            attempts++;
            if(num == TargetNumber)
            {
                Console.WriteLine($"You guessed the number in {attempts}");
            }
            else if(num<TargetNumber)
            {
                Console.WriteLine("number too low");
            }
            else if(num>TargetNumber)
            {
                Console.WriteLine("number too high");
            }
        }
    }
}