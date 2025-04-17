class Program
{
    static void Main()
    {
        Console.WriteLine("How many numbers you want to enter in the array?: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Enter the {i + 1} th element");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Find: \n1.Sum\n2.Average\n3.Max\n4.Min\n5.Builtin Functions\nEnter Choice:");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine(sum);
        }
        else if (choice == 2) 
        {
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum = sum + arr[i];
            }
            int average = 0;
            average = sum / size;
            Console.WriteLine(average);
        }
        else if(choice == 3)
        {
            int max = arr[0];
            for(int i=1; i<size;i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
        }
        else if(choice == 4)
        {
            int min = arr[0];
            for (int i = 1; i < size; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine(min);
        }
        else if( choice == 5)
        {
            Console.WriteLine($"Sum of the numbers is: {arr.Sum()}");
            Console.WriteLine($"Average of all the numbers: {arr.Average()}");
            Console.WriteLine($"Maximum of all numbers: {arr.Max()}");
            Console.WriteLine($"Minimum of all numbers: {arr.Min()}");
        }
        else
        {
            Console.WriteLine("Enter valid input");
        }
    }
}