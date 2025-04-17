using System.Globalization;

class Program
{
    static List<string> todos = new List<string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1. Add Todo Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Remove Todo Task");
            Console.WriteLine("4. Exit");
            Console.WriteLine("What you wanna do?: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Add a todo task");
                    todos.Add(Console.ReadLine());
                    break;
                case "2":
                    Console.WriteLine("All tasks:");
                    for (int i = 0; i < todos.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {todos[i]}");
                    }
                    break;
                case "3":
                    Console.WriteLine("Enter the index to remove: ");
                    int index = Convert.ToInt32(Console.ReadLine()) - 1;

                    todos.RemoveAt(index);
                    break;

                case "4":
                    return;
            }
        }
    }
}