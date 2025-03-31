using System;

// Interface declaration
interface IEmployee
{
    void DisplayDetails();
}

// Base class: Employee
class Employee : IEmployee
{
    private static int employeeCount; // Static field
    public string Name { get; set; }
    public int ID { get; set; }
    public double Salary { get; set; }

    // Static constructor (runs only once)
    static Employee()
    {
        employeeCount = 0;
        Console.WriteLine("Employee system initialized...");
    }

    // Private constructor (not directly accessible)
    private Employee()
    {
        ID = ++employeeCount;
    }

    // Public constructor
    public Employee(string name, double salary) : this() // Calls private constructor
    {
        Name = name;
        Salary = salary;
    }

    // Virtual method for overriding
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"\nEmployee ID: {ID}\nName: {Name}\nSalary: {Salary:C}");
    }

    // Method hiding using "new" keyword
    public new void ShowGreeting()
    {
        Console.WriteLine("Welcome to Employee Management System!");
    }
}

// Derived class: Manager (inherits Employee)
class Manager : Employee
{
    public int TeamSize { get; set; }

    // Constructor
    public Manager(string name, double salary, int teamSize) : base(name, salary)
    {
        TeamSize = teamSize;
    }

    // Overriding virtual method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Role: Manager\nTeam Size: {TeamSize}");
    }
}

// Derived class: Developer (inherits Employee)
class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }

    // Constructor
    public Developer(string name, double salary, string programmingLanguage) : base(name, salary)
    {
        ProgrammingLanguage = programmingLanguage;
    }

    // Overriding virtual method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Role: Developer\nProgramming Language: {ProgrammingLanguage}");
    }
}

// Main Execution Class
class EmployeeManagement
{
    public static void RunEmployeeSystem()
    {
        Console.WriteLine("\n===== Employee Management System =====\n");

        Employee emp1 = new Manager("Alice", 75000, 5);
        emp1.DisplayDetails();

        Employee emp2 = new Developer("Bob", 60000, "C#");
        emp2.DisplayDetails();

        Console.WriteLine("\nCalling the hidden method:");
        emp1.ShowGreeting(); // Calls Employee's method
    }
}
