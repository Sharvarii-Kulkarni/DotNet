using System;
using System.Diagnostics;

class Student
{
    private string name;

    public string Name
    {  get { return name; } 
       set {
            if (!string.IsNullOrWhiteSpace(value))
                name = value;
            else
                Console.WriteLine("Name cannot be empty");
       }
    }
     public void show()
    {
        Console.WriteLine($"Student name is: {Name}");
    }
}
class Program()
{
    static void Main()
    {
        Student s = new Student();
        s.Name = "Sharvari";
        s.show();

        s.Name = " ";
    }
}